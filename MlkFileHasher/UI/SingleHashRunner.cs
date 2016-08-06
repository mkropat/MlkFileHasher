using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MlkFileHasher.Formatting;
using MlkFileHasher.Hash;
using MlkFileHasher.Util;

namespace MlkFileHasher.UI
{
    public class SingleHashRunner
    {
        readonly SupportedHashAlgorithm _algorithm;
        readonly IEnumerable<SingleHashResultControls> _controls;
        readonly IDictionary<IHashUIFormat, SingleHashResultControls> _formatToControls;
        readonly IProgress<int> _progress;

        public SingleHashRunner(SupportedHashAlgorithm algorithm, IDictionary<IHashUIFormat, SingleHashResultControls> formatToControls)
        {
            _algorithm = algorithm;
            _controls = formatToControls.Values;
            _formatToControls = formatToControls;

            _progress = new Progress<int>(value =>
            {
                foreach (var p in _controls.Select(cs => cs.Progress))
                    p.Value = value;

                SetOutputMode(ResultDisplayMode.ProgressBar);
            });
        }

        void SetOutputMode(ResultDisplayMode mode)
        {
            foreach (var p in _controls.Select(cs => cs.Progress))
                p.Visible = mode == ResultDisplayMode.ProgressBar;

            foreach (var r in _controls.Select(cs => cs.Result))
                r.Visible = mode == ResultDisplayMode.ResultText;
        }

        public void Reset()
        {
            foreach (var r in _controls.Select(cs => cs.Result))
                r.Text = string.Empty;

            foreach (var d in _controls.Select(cs => cs.Duration))
                d.Text = string.Empty;

            SetOutputMode(ResultDisplayMode.ResultText);
        }

        public async Task StartHashing(FileInfo fi, CancellationToken cancelToken)
        {
            _progress.Report(0);
            DateTime startTime = DateTime.MinValue;

            var hashResult = await Task.Run(() => {
                startTime = DateTime.UtcNow;

                return ComputeSingleHash(
                    fi,
                    _algorithm.Factory,
                    _progress,
                    cancelToken);
            });

            SetOutputMode(ResultDisplayMode.ResultText);

            foreach (var kv in _formatToControls)
                kv.Value.Result.Text = kv.Key.Format(hashResult);

            var duration = DateTime.UtcNow - startTime;
            foreach (var d in _controls.Select(cs => cs.Duration))
                d.Text = FormatDuration(duration);
        }

        static byte[] ComputeSingleHash(FileInfo fi, Func<IHashAlgorithm> hashFactory, IProgress<int> progress, CancellationToken cancelToken)
        {
            using (var myStream = fi.OpenRead())
            using (var hasher = hashFactory())
            {
                var progressThrottler = new ActionThrottler(TimeSpan.FromMilliseconds(200));

                var buf = new byte[16 * 1024];
                long i = 0;
                var read = 0;
                do
                {
                    cancelToken.ThrowIfCancellationRequested();

                    read = myStream.Read(buf, 0, buf.Length);
                    i += read;

                    hasher.Process(buf, read);

                    progressThrottler.Do(() =>
                    {
                        progress.Report(GetPercentage(i, fi.Length));
                    });
                }
                while (read > 0);

                hasher.Done();

                return hasher.Hash;
            }
        }

        static int GetPercentage(long val, long total)
        {
            var percent = ((double)val) / total;
            return (int)Math.Round(percent * 100);
        }

        public static string FormatDuration(TimeSpan duration)
        {
            return $"{duration.Minutes}:{duration.Seconds}.{duration.Milliseconds.ToString("000")}";
        }

        enum ResultDisplayMode
        {
            ResultText,
            ProgressBar
        }
    }
}
