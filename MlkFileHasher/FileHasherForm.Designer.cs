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
            this.filePath.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.Location = new System.Drawing.Point(43, 7);
            this.filePath.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(657, 21);
            this.filePath.TabIndex = 0;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.browseButton.Location = new System.Drawing.Point(706, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileInfoPanel
            // 
            this.fileInfoPanel.ColumnCount = 3;
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileInfoPanel.Controls.Add(this.hashResultsTabs, 0, 2);
            this.fileInfoPanel.Controls.Add(this.filePath, 1, 0);
            this.fileInfoPanel.Controls.Add(this.browseButton, 2, 0);
            this.fileInfoPanel.Controls.Add(this.filePathLabel, 0, 0);
            this.fileInfoPanel.Controls.Add(this.fileInfoLabel, 1, 1);
            this.fileInfoPanel.Controls.Add(this.manualVerificationLabel, 0, 3);
            this.fileInfoPanel.Controls.Add(this.manualVerification, 0, 4);
            this.fileInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.fileInfoPanel.Name = "fileInfoPanel";
            this.fileInfoPanel.RowCount = 5;
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.fileInfoPanel.Size = new System.Drawing.Size(784, 282);
            this.fileInfoPanel.TabIndex = 2;
            // 
            // hashResultsTabs
            // 
            this.fileInfoPanel.SetColumnSpan(this.hashResultsTabs, 3);
            this.hashResultsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hashResultsTabs.Location = new System.Drawing.Point(3, 57);
            this.hashResultsTabs.Name = "hashResultsTabs";
            this.hashResultsTabs.SelectedIndex = 0;
            this.hashResultsTabs.Size = new System.Drawing.Size(778, 172);
            this.hashResultsTabs.TabIndex = 4;
            // 
            // filePathLabel
            // 
            this.filePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathLabel.Location = new System.Drawing.Point(3, 2);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(34, 29);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "File:";
            this.filePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.AutoSize = true;
            this.fileInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoLabel.Location = new System.Drawing.Point(43, 31);
            this.fileInfoLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(657, 13);
            this.fileInfoLabel.TabIndex = 4;
            this.fileInfoLabel.Text = "Info output";
            // 
            // manualVerificationLabel
            // 
            this.manualVerificationLabel.AutoSize = true;
            this.fileInfoPanel.SetColumnSpan(this.manualVerificationLabel, 2);
            this.manualVerificationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualVerificationLabel.Location = new System.Drawing.Point(15, 242);
            this.manualVerificationLabel.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.manualVerificationLabel.Name = "manualVerificationLabel";
            this.manualVerificationLabel.Size = new System.Drawing.Size(685, 13);
            this.manualVerificationLabel.TabIndex = 5;
            this.manualVerificationLabel.Text = "Paste a hash to compare it:";
            this.manualVerificationLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // manualVerification
            // 
            this.fileInfoPanel.SetColumnSpan(this.manualVerification, 2);
            this.manualVerification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualVerification.Location = new System.Drawing.Point(15, 258);
            this.manualVerification.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.manualVerification.Name = "manualVerification";
            this.manualVerification.Size = new System.Drawing.Size(685, 20);
            this.manualVerification.TabIndex = 6;
            this.manualVerification.Click += new System.EventHandler(this.SelectAll);
            this.manualVerification.TextChanged += new System.EventHandler(this.manualVerification_TextChanged);
            // 
            // FileHasherForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 282);
            this.Controls.Add(this.fileInfoPanel);
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
