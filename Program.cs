using System;
using System.Threading;
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
            bool isFirstInstance;
            using var mutex = new Mutex(true, "Local\\CryptaTray", out isFirstInstance);
            if (!isFirstInstance)
            {
                // Optionally, activate the existing window here
                MessageBox.Show("CryptaTray is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
