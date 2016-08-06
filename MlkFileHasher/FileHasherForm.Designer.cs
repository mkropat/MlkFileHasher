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
            this.filePathLabel = new System.Windows.Forms.Label();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.hashResultsTabs = new System.Windows.Forms.TabControl();
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
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.browseButton.Location = new System.Drawing.Point(706, 3);
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
            this.fileInfoPanel.Controls.Add(this.filePath, 1, 0);
            this.fileInfoPanel.Controls.Add(this.browseButton, 2, 0);
            this.fileInfoPanel.Controls.Add(this.filePathLabel, 0, 0);
            this.fileInfoPanel.Controls.Add(this.fileInfoLabel, 1, 1);
            this.fileInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.fileInfoPanel.Name = "fileInfoPanel";
            this.fileInfoPanel.RowCount = 2;
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fileInfoPanel.Size = new System.Drawing.Size(784, 49);
            this.fileInfoPanel.TabIndex = 2;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filePathLabel.Location = new System.Drawing.Point(3, 0);
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
            this.fileInfoLabel.Location = new System.Drawing.Point(43, 29);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(657, 20);
            this.fileInfoLabel.TabIndex = 4;
            this.fileInfoLabel.Text = "Info output";
            // 
            // hashResultsTabs
            // 
            this.hashResultsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hashResultsTabs.Location = new System.Drawing.Point(0, 49);
            this.hashResultsTabs.Name = "hashResultsTabs";
            this.hashResultsTabs.SelectedIndex = 0;
            this.hashResultsTabs.Size = new System.Drawing.Size(784, 174);
            this.hashResultsTabs.TabIndex = 4;
            // 
            // FileHasherForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 223);
            this.Controls.Add(this.hashResultsTabs);
            this.Controls.Add(this.fileInfoPanel);
            this.Name = "FileHasherForm";
            this.Text = "MlkFileHasher";
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
    }
}
