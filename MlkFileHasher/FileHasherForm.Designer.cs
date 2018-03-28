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
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.manualVerificationLabel = new System.Windows.Forms.Label();
            this.manualVerification = new System.Windows.Forms.TextBox();
            this.fileInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePath.Location = new System.Drawing.Point(164, 15);
            this.filePath.Margin = new System.Windows.Forms.Padding(4, 15, 4, 5);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(888, 26);
            this.filePath.TabIndex = 0;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.browseButton.Location = new System.Drawing.Point(1059, 8);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(112, 35);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileInfoPanel
            // 
            this.fileInfoPanel.ColumnCount = 3;
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileInfoPanel.Controls.Add(this.hashResultsTabs, 0, 3);
            this.fileInfoPanel.Controls.Add(this.filePath, 1, 0);
            this.fileInfoPanel.Controls.Add(this.browseButton, 2, 0);
            this.fileInfoPanel.Controls.Add(this.filePathLabel, 0, 0);
            this.fileInfoPanel.Controls.Add(this.manualVerificationLabel, 0, 1);
            this.fileInfoPanel.Controls.Add(this.manualVerification, 1, 1);
            this.fileInfoPanel.Controls.Add(this.fileInfoLabel, 0, 4);
            this.fileInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.fileInfoPanel.Margin = new System.Windows.Forms.Padding(4, 10, 4, 15);
            this.fileInfoPanel.Name = "fileInfoPanel";
            this.fileInfoPanel.RowCount = 5;
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.Size = new System.Drawing.Size(1176, 434);
            this.fileInfoPanel.TabIndex = 2;
            // 
            // hashResultsTabs
            // 
            this.fileInfoPanel.SetColumnSpan(this.hashResultsTabs, 3);
            this.hashResultsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hashResultsTabs.Location = new System.Drawing.Point(4, 113);
            this.hashResultsTabs.Margin = new System.Windows.Forms.Padding(4, 25, 4, 0);
            this.hashResultsTabs.Name = "hashResultsTabs";
            this.hashResultsTabs.SelectedIndex = 0;
            this.hashResultsTabs.Size = new System.Drawing.Size(1168, 281);
            this.hashResultsTabs.TabIndex = 4;
            // 
            // filePathLabel
            // 
            this.filePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathLabel.Location = new System.Drawing.Point(3, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(154, 46);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "File to hash:";
            this.filePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.AutoSize = true;
            this.fileInfoPanel.SetColumnSpan(this.fileInfoLabel, 3);
            this.fileInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoLabel.Location = new System.Drawing.Point(15, 404);
            this.fileInfoLabel.Margin = new System.Windows.Forms.Padding(15, 10, 3, 10);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(1158, 20);
            this.fileInfoLabel.TabIndex = 4;
            this.fileInfoLabel.Text = "Info output";
            // 
            // manualVerificationLabel
            // 
            this.manualVerificationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualVerificationLabel.Location = new System.Drawing.Point(3, 46);
            this.manualVerificationLabel.Name = "manualVerificationLabel";
            this.manualVerificationLabel.Size = new System.Drawing.Size(154, 42);
            this.manualVerificationLabel.TabIndex = 5;
            this.manualVerificationLabel.Text = "Expected hash:";
            this.manualVerificationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manualVerification
            // 
            this.manualVerification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualVerification.Location = new System.Drawing.Point(164, 57);
            this.manualVerification.Margin = new System.Windows.Forms.Padding(4, 11, 4, 5);
            this.manualVerification.Name = "manualVerification";
            this.manualVerification.Size = new System.Drawing.Size(888, 26);
            this.manualVerification.TabIndex = 6;
            this.manualVerification.Click += new System.EventHandler(this.SelectAll);
            this.manualVerification.TextChanged += new System.EventHandler(this.manualVerification_TextChanged);
            // 
            // FileHasherForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 434);
            this.Controls.Add(this.fileInfoPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}
