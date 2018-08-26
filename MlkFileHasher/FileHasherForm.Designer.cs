namespace MlkFileHasher
{
    partial class FileHasherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.hashResultsTabs = new System.Windows.Forms.TabControl();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.manualVerificationLabel = new System.Windows.Forms.Label();
            this.manualVerification = new System.Windows.Forms.TextBox();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.pasteButton = new System.Windows.Forms.Button();
            this.fileInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePath.Location = new System.Drawing.Point(119, 3);
            this.filePath.Margin = new System.Windows.Forms.Padding(0, 3, 0, 1);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(802, 26);
            this.filePath.TabIndex = 0;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.browseButton.AutoSize = true;
            this.browseButton.Location = new System.Drawing.Point(921, 1);
            this.browseButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(72, 30);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileInfoPanel
            // 
            this.fileInfoPanel.ColumnCount = 3;
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileInfoPanel.Controls.Add(this.hashResultsTabs, 0, 3);
            this.fileInfoPanel.Controls.Add(this.filePath, 1, 0);
            this.fileInfoPanel.Controls.Add(this.browseButton, 2, 0);
            this.fileInfoPanel.Controls.Add(this.filePathLabel, 0, 0);
            this.fileInfoPanel.Controls.Add(this.manualVerificationLabel, 0, 1);
            this.fileInfoPanel.Controls.Add(this.manualVerification, 1, 1);
            this.fileInfoPanel.Controls.Add(this.fileInfoLabel, 0, 4);
            this.fileInfoPanel.Controls.Add(this.pasteButton, 2, 1);
            this.fileInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.fileInfoPanel.Margin = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.fileInfoPanel.Name = "fileInfoPanel";
            this.fileInfoPanel.RowCount = 5;
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.Size = new System.Drawing.Size(993, 494);
            this.fileInfoPanel.TabIndex = 2;
            // 
            // hashResultsTabs
            // 
            this.fileInfoPanel.SetColumnSpan(this.hashResultsTabs, 3);
            this.hashResultsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hashResultsTabs.Location = new System.Drawing.Point(0, 77);
            this.hashResultsTabs.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.hashResultsTabs.Name = "hashResultsTabs";
            this.hashResultsTabs.SelectedIndex = 0;
            this.hashResultsTabs.Size = new System.Drawing.Size(993, 393);
            this.hashResultsTabs.TabIndex = 4;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathLabel.Location = new System.Drawing.Point(0, 0);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(119, 32);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "File to hash:";
            this.filePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manualVerificationLabel
            // 
            this.manualVerificationLabel.AutoSize = true;
            this.manualVerificationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualVerificationLabel.Location = new System.Drawing.Point(0, 32);
            this.manualVerificationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.manualVerificationLabel.Name = "manualVerificationLabel";
            this.manualVerificationLabel.Size = new System.Drawing.Size(119, 40);
            this.manualVerificationLabel.TabIndex = 5;
            this.manualVerificationLabel.Text = "Expected hash:";
            this.manualVerificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manualVerification
            // 
            this.manualVerification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualVerification.Location = new System.Drawing.Point(119, 34);
            this.manualVerification.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
            this.manualVerification.Name = "manualVerification";
            this.manualVerification.Size = new System.Drawing.Size(802, 26);
            this.manualVerification.TabIndex = 6;
            this.manualVerification.Click += new System.EventHandler(this.SelectAll);
            this.manualVerification.TextChanged += new System.EventHandler(this.manualVerification_TextChanged);
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.AutoSize = true;
            this.fileInfoPanel.SetColumnSpan(this.fileInfoLabel, 3);
            this.fileInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoLabel.Location = new System.Drawing.Point(1, 472);
            this.fileInfoLabel.Margin = new System.Windows.Forms.Padding(1, 2, 0, 2);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(992, 20);
            this.fileInfoLabel.TabIndex = 4;
            this.fileInfoLabel.Text = "Info output";
            // 
            // pasteButton
            // 
            this.pasteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pasteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pasteButton.Image = global::MlkFileHasher.Properties.Resources.clipboard;
            this.pasteButton.Location = new System.Drawing.Point(921, 33);
            this.pasteButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(64, 38);
            this.pasteButton.TabIndex = 7;
            this.pasteButton.UseVisualStyleBackColor = true;
            // 
            // FileHasherForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 494);
            this.Controls.Add(this.fileInfoPanel);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "FileHasherForm";
            this.Text = "MlkFileHasher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileHasherForm_FormClosed);
            this.Load += new System.EventHandler(this.FileHasherForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileHasherForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileHasherForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.FileHasherForm_DragLeave);
            this.fileInfoPanel.ResumeLayout(false);
            this.fileInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TableLayoutPanel fileInfoPanel;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.TabControl hashResultsTabs;
        private System.Windows.Forms.Label manualVerificationLabel;
        private System.Windows.Forms.TextBox manualVerification;
        private System.Windows.Forms.Button pasteButton;
    }
}
