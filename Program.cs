using System;
using System.Windows.Forms;

namespace CryptaTray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // migrate settings from older config files for previous assembly versions
            CryptaTray.Properties.Settings.Default.Upgrade();

            FNLog.Initialize();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CommandsMenu());
        }
    }
}
