using DorkMaster;
using System;
using System.Threading;
using System.Windows.Forms;

namespace TelegramJoinApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew;
            using (Mutex mutex = new Mutex(true, "ApplicationName", out createdNew))
            {
                if (!createdNew)
                {
                    MessageBox.Show("The Program is already running.");
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                FormJoin frmJoin = new FormJoin();
                Application.Run(frmJoin);

                if (frmJoin.DialogResult == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}
