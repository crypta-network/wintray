﻿using CryptaTray.Browsers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NLog;
using NLog.Config;

namespace CryptaTray
{
    public partial class PreferencesWindow : Form
    {
        private const int StartIconIndex = 0;
        private const int StartFreenetIndex = 1;

        private const string RegistryStartupName = "Crypta";
        private const string StartupKeyLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private readonly string _initialCustomLocation;

        public PreferencesWindow(IEnumerable<string> availableBrowsers)
        {
            InitializeComponent();

            StartupCheckboxList.SetItemChecked(StartIconIndex,
                                               Properties.Settings.Default.StartIcon);
            StartupCheckboxList.SetItemChecked(StartFreenetIndex,
                                               Properties.Settings.Default.StartCrypta);

            // TODO: Localize?
            BrowserChoice.Items.Add(BrowserUtil.Auto);
            foreach (var browser in availableBrowsers)
            {
                BrowserChoice.Items.Add(browser);
            }
            BrowserChoice.Text = Properties.Settings.Default.UseBrowser;
            if (!BrowserChoice.Items.Contains(BrowserChoice.Text))
            {
                // TODO: User's preference not found. Worthy of a message box?
                BrowserChoice.Text = BrowserUtil.Auto;
            }

            SlowStartOption.Checked = Properties.Settings.Default.ShowSlowOpenTip;

            LogLevelChoice.Text = Properties.Settings.Default.LogLevel;

            CustomLocationDisplay.Text = Properties.Settings.Default.CustomLocation;
            _initialCustomLocation = Properties.Settings.Default.CustomLocation;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartIcon = StartupCheckboxList.GetItemChecked(StartIconIndex);
            Properties.Settings.Default.StartCrypta = StartupCheckboxList.GetItemChecked(StartFreenetIndex);

            Properties.Settings.Default.UseBrowser = (string)BrowserChoice.SelectedItem;

            Properties.Settings.Default.ShowSlowOpenTip = SlowStartOption.Checked;

            Properties.Settings.Default.LogLevel = LogLevelChoice.Text;

            Properties.Settings.Default.CustomLocation = CustomLocationDisplay.Text;

            Properties.Settings.Default.Save();

            foreach (var rule in LogManager.Configuration.LoggingRules)
            {
                ChangeRuleMinLevel(rule, LogLevel.FromString(LogLevelChoice.Text));
            }

            if (Properties.Settings.Default.StartIcon)
            {
                // Start Crypta or just the icon.
                SetStartupArguments(Properties.Settings.Default.StartCrypta ? "-start" : "");
            }
            else if (Properties.Settings.Default.StartCrypta)
            {
                // Just start Crypta.
                SetStartupArguments("-start -hide");
            }
            else
            {
                // Do not start.
                SetStartupArguments(null);
            }

            if (_initialCustomLocation != CustomLocationDisplay.Text)
            {
                // TODO: Reload config without restart? What would be the difference?
                Application.Restart();
            }

            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Set the tray arguments on Windows startup, or remove if from startup if arguments is null.
        private static void SetStartupArguments(string arguments)
        {
            using (var currentUser32 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32))
            using (var key = currentUser32.OpenSubKey(StartupKeyLocation, true))
            {
                // TODO: Assuming startup registry location exists. Is this viable?
                key.DeleteValue(RegistryStartupName, false);

                if (arguments != null)
                {
                    /*
                     * Double quotes are required around the executable path to get multiple(?) command
                     * line arguments.
                     */
                    key.SetValue(RegistryStartupName, '"' + Application.ExecutablePath + "\" " + arguments);
                }
            }
        }

        private static void ChangeRuleMinLevel(LoggingRule rule, LogLevel minLevel)
        {
            /*
             * Based on how the LoggingLevel initializes its logging levels when given a minLevel,
             * but because LogLevel.MinLevel and LogLevel.MaxLevel are not publically accessible,
             * their current values are hardcoded. TODO: This is fragile!
             */
            for (var i = LogLevel.Trace.Ordinal; i < minLevel.Ordinal; i++)
            {
                rule.DisableLoggingForLevel(LogLevel.FromOrdinal(i));
            }
            for (var i = minLevel.Ordinal; i <= LogLevel.Fatal.Ordinal; i++)
            {
                rule.EnableLoggingForLevel(LogLevel.FromOrdinal(i));
            }
            LogManager.ReconfigExistingLoggers();
        }

        private void customLocationClear_Click(object sender, EventArgs e)
        {
            CustomLocationDisplay.Text = String.Empty;
        }

        private void CustomLocationBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                CustomLocationDisplay.Text = SelectCustomLocation(this);
            }
            catch (OperationCanceledException)
            {
                /* User does not want to change the directory. */
            }
        }

        private static string SelectCustomLocation(IWin32Window owner)
        {
            using (var dialog = new FolderBrowserDialog
            {
                Description = strings.ChooseCustomLocation,
                ShowNewFolderButton = false,
            })
            {
                if (dialog.ShowDialog(owner) == DialogResult.Cancel)
                {
                    throw new OperationCanceledException();
                }

                return dialog.SelectedPath;
            }
        }

        public static void PromptCustomLocation(IWin32Window owner)
        {
            Properties.Settings.Default.CustomLocation = SelectCustomLocation(owner);
            Properties.Settings.Default.Save();
        }
    }
}
