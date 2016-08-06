using System;
using System.Windows.Forms;

namespace MlkFileHasher
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FileHasherForm());
        }
    }
}
