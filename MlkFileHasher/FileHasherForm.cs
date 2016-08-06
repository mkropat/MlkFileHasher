using System;
using System.Windows.Forms;

namespace MlkFileHasher
{
    public partial class FileHasherForm : Form
    {
        public FileHasherForm()
        {
            InitializeComponent();
        }

        void browseButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
                filePath.Text = openFileDialog.FileName;
        }
    }
}
