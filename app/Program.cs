using butik.forms.login;
using SQLToolkitNS;
using System;
using System.Windows.Forms;

namespace butik
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLToolkit.setConnStr(global::butik.Properties.Settings.Default.connStr);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmMain());
            Application.Run(new frmLogin());
        }
    }
}
