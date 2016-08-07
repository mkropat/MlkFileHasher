using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MlkFileHasher.Formatting;
using MlkFileHasher.Hash;
using MlkFileHasher.UI;
using MlkFileHasher.Util;

namespace MlkFileHasher
{
    public partial class FileHasherForm : Form
    {
        readonly SupportedHashAlgorithm[] _supportedHashes = new[]
        {
            new SupportedHashAlgorithm { Name = "CRC-32", Factory = Crc32.Factory },
            new SupportedHashAlgorithm { Name = "MD5", Factory = SystemHash.GetFactory(MD5.Create) },
            new SupportedHashAlgorithm { Name = "SHA1", Factory = SystemHash.GetFactory(SHA1.Create) },
            new SupportedHashAlgorithm { Name = "SHA-256", Factory = SystemHash.GetFactory(SHA256.Create) },
            new SupportedHashAlgorithm { Name = "SHA-512", Factory = SystemHash.GetFactory(SHA512.Create) },
        };

        readonly IHashUIFormat[] _supportedFormatters = new IHashUIFormat[]
        {
            new HexUIFormat(),
            new Base64UIFormat(),
            //new DigitsUIFormat(),
        };

        readonly List<SingleHashRunner> _hashRunners = new List<SingleHashRunner>();
        readonly StatusLineUpdater _statusUpdater;

        Task _backgroundWorker = Task.Delay(0);
        CancellationTokenSource _lastCts;

        public FileHasherForm()
        {
            InitializeComponent();

            _statusUpdater = new StatusLineUpdater(status => {
                fileInfoLabel.Text = status;
            });
        }

        void FileHasherForm_Load(object sender, EventArgs e)
        {
            _statusUpdater.SetStatus("Select a file");

            var formatterHashPairs = new List<Tuple<IHashUIFormat, Dictionary<SupportedHashAlgorithm, SingleHashResultControls>>>();
            var formatToHashToControls = new Dictionary<IHashUIFormat, Dictionary<SupportedHashAlgorithm, SingleHashResultControls>>();

            hashResultsTabs.TabPages.Clear();
            foreach (var format in _supportedFormatters)
            {
                var tab = new TabPage(format.Name);
                hashResultsTabs.TabPages.Add(tab);

                var resultsPanel = new TableLayoutPanel
                {
                    AutoSize = true,
                    Dock = DockStyle.Top,
                };
                resultsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
                resultsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                resultsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
                resultsPanel.RowCount = _supportedHashes.Length;

                tab.Controls.Add(resultsPanel);

                var hashToControls = new Dictionary<SupportedHashAlgorithm, SingleHashResultControls>();
                for (var i = 0; i < _supportedHashes.Length; i++)
                {
                    var hash = _supportedHashes[i];

                    var controls = new SingleHashResultControls
                    {
                        Duration = new Label
                        {
                            TextAlign = ContentAlignment.MiddleLeft,
                        },
                        Progress = new ProgressBar
                        {
                            Dock = DockStyle.Fill,
                            Visible = false,
                        },
                        Result = new TextBox
                        {
                            Dock = DockStyle.Fill,
                            Font = new Font(FontFamily.GenericSansSerif, 10),
                            ReadOnly = true,
                        },
                    };

                    controls.Result.Click += CopyTextToClipboard;

                    var label = new Label
                    {
                        Dock = DockStyle.Fill,
                        Text = hash.Name,
                        TextAlign = ContentAlignment.MiddleRight,
                    };
                    resultsPanel.Controls.Add(label, 0, i);

                    resultsPanel.Controls.Add(controls.Progress, 1, i);
                    resultsPanel.Controls.Add(controls.Result, 1, i);
                    resultsPanel.Controls.Add(controls.Duration, 2, i);

                    hashToControls.Add(hash, controls);
                }

                formatToHashToControls.Add(format, hashToControls);
            }

            var hashToFormatToControls = FlipDictOfDict(formatToHashToControls);
            _hashRunners.AddRange(hashToFormatToControls.Select(kv => new SingleHashRunner(kv.Key, kv.Value)));
        }

        void browseButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
                filePath.Text = openFileDialog.FileName;
        }

        void FileHasherForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                _statusUpdater.SetOverrideStatus("Drop file anywhere to hash it");
            }
        }

        void FileHasherForm_DragLeave(object sender, EventArgs e)
        {
            _statusUpdater.ClearOverrideStatus();
        }

        void FileHasherForm_DragDrop(object sender, DragEventArgs e)
        {
            _statusUpdater.ClearOverrideStatus();

            var filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (filenames.Length > 0)
            {
                filePath.Text = filenames[0];
            }
        }

        async void filePath_TextChanged(object sender, EventArgs e)
        {
            _lastCts?.Cancel();
            var myCts = _lastCts = new CancellationTokenSource();

            try
            {
                await _backgroundWorker;

                myCts.Token.ThrowIfCancellationRequested();

                var worker = ComputeHashes(filePath.Text, myCts.Token);

                _backgroundWorker = SwallowErrors(worker);

                await worker;
            }
            catch (OperationCanceledException)
            {
            }
            finally
            {
                _lastCts = null;
                myCts.Dispose();
            }
        }

        async Task ComputeHashes(string path, CancellationToken cancelToken)
        {
            foreach (var runner in _hashRunners)
                runner.Reset();

            FileInfo fi;
            try
            {
                fi = FileUtil.ReadFileInfo(path);
            }
            catch (InvalidFilePath ex)
            {
                _statusUpdater.SetStatus(ex.Message);
                return;
            }

            _statusUpdater.SetStatus("Hashing...");
            var startTime = DateTime.UtcNow;

            await Task.WhenAll(_hashRunners
                .Select(r => r.StartHashing(fi, cancelToken))
                .ToArray());

            var duration = DateTime.UtcNow - startTime;
            _statusUpdater.SetStatus($"Hasing completed in {SingleHashRunner.FormatDuration(duration)}");
        }

        void FileHasherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _lastCts?.Cancel();
        }

        static void CopyTextToClipboard(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            Clipboard.SetText(textbox.Text);
            textbox.SelectAll();
        }

        static Dictionary<K2, Dictionary<K1, T>> FlipDictOfDict<K1, K2, T>(Dictionary<K1, Dictionary<K2, T>> dict)
        {
            var newKeys = dict.Values.SelectMany(v => v.Keys).Distinct();

            return newKeys.ToDictionary(
                k => k,
                k => dict.ToDictionary(kv => kv.Key, kv => kv.Value[k]));
        }

        static async Task SwallowErrors(Task task)
        {
            try
            {
                await task;
            }
            catch (Exception)
            {
            }
        }
    }
}
