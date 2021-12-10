using DevIdent.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DevIdent.Classes
{
    internal static class Program
    {
        private static bool IsSingleInstance()
        {
            new Mutex(true, "DevMutex", out bool flag);
            return flag;
        }

        [STAThread]
        private static void Main()
        {
            if (!IsSingleInstance())
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}