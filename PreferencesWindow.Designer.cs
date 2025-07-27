namespace CryptaTray
{
    partial class PreferencesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWindow));
            StartupCheckboxList = new System.Windows.Forms.CheckedListBox();
            StartupLabel = new System.Windows.Forms.Label();
            ApplyButton = new System.Windows.Forms.Button();
            ClosePreferencesButton = new System.Windows.Forms.Button();
            BrowserChoice = new System.Windows.Forms.ComboBox();
            BrowserLabel = new System.Windows.Forms.Label();
            BehaviorLabel = new System.Windows.Forms.Label();
            SlowStartOption = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            LogLevelChoice = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            CustomLocationDisplay = new System.Windows.Forms.TextBox();
            customLocationClear = new System.Windows.Forms.Button();
            CustomLocationBrowse = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // StartupCheckboxList
            // 
            StartupCheckboxList.BackColor = System.Drawing.SystemColors.Window;
            StartupCheckboxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            StartupCheckboxList.CheckOnClick = true;
            resources.ApplyResources(StartupCheckboxList, "StartupCheckboxList");
            StartupCheckboxList.FormattingEnabled = true;
            StartupCheckboxList.Items.AddRange(new object[] { resources.GetString("StartupCheckboxList.Items"), resources.GetString("StartupCheckboxList.Items1") });
            StartupCheckboxList.Name = "StartupCheckboxList";
            // 
            // StartupLabel
            // 
            resources.ApplyResources(StartupLabel, "StartupLabel");
            StartupLabel.Name = "StartupLabel";
            // 
            // ApplyButton
            // 
            resources.ApplyResources(ApplyButton, "ApplyButton");
            ApplyButton.Name = "ApplyButton";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += Apply_Click;
            // 
            // ClosePreferencesButton
            // 
            ClosePreferencesButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(ClosePreferencesButton, "ClosePreferencesButton");
            ClosePreferencesButton.Name = "ClosePreferencesButton";
            ClosePreferencesButton.UseVisualStyleBackColor = true;
            ClosePreferencesButton.Click += Cancel_Click;
            // 
            // BrowserChoice
            // 
            resources.ApplyResources(BrowserChoice, "BrowserChoice");
            BrowserChoice.FormattingEnabled = true;
            BrowserChoice.Name = "BrowserChoice";
            // 
            // BrowserLabel
            // 
            resources.ApplyResources(BrowserLabel, "BrowserLabel");
            BrowserLabel.Name = "BrowserLabel";
            // 
            // BehaviorLabel
            // 
            resources.ApplyResources(BehaviorLabel, "BehaviorLabel");
            BehaviorLabel.Name = "BehaviorLabel";
            // 
            // SlowStartOption
            // 
            resources.ApplyResources(SlowStartOption, "SlowStartOption");
            SlowStartOption.Name = "SlowStartOption";
            SlowStartOption.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // LogLevelChoice
            // 
            resources.ApplyResources(LogLevelChoice, "LogLevelChoice");
            LogLevelChoice.FormattingEnabled = true;
            LogLevelChoice.Items.AddRange(new object[] { resources.GetString("LogLevelChoice.Items"), resources.GetString("LogLevelChoice.Items1"), resources.GetString("LogLevelChoice.Items2"), resources.GetString("LogLevelChoice.Items3"), resources.GetString("LogLevelChoice.Items4") });
            LogLevelChoice.Name = "LogLevelChoice";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // CustomLocationDisplay
            // 
            resources.ApplyResources(CustomLocationDisplay, "CustomLocationDisplay");
            CustomLocationDisplay.Name = "CustomLocationDisplay";
            CustomLocationDisplay.ReadOnly = true;
            // 
            // customLocationClear
            // 
            customLocationClear.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(customLocationClear, "customLocationClear");
            customLocationClear.Name = "customLocationClear";
            customLocationClear.UseVisualStyleBackColor = false;
            customLocationClear.Click += customLocationClear_Click;
            // 
            // CustomLocationBrowse
            // 
            resources.ApplyResources(CustomLocationBrowse, "CustomLocationBrowse");
            CustomLocationBrowse.Name = "CustomLocationBrowse";
            CustomLocationBrowse.UseVisualStyleBackColor = true;
            CustomLocationBrowse.Click += CustomLocationBrowse_Click;
            // 
            // PreferencesWindow
            // 
            AcceptButton = ApplyButton;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = ClosePreferencesButton;
            Controls.Add(CustomLocationBrowse);
            Controls.Add(customLocationClear);
            Controls.Add(CustomLocationDisplay);
            Controls.Add(label2);
            Controls.Add(LogLevelChoice);
            Controls.Add(label1);
            Controls.Add(SlowStartOption);
            Controls.Add(BehaviorLabel);
            Controls.Add(BrowserLabel);
            Controls.Add(BrowserChoice);
            Controls.Add(ClosePreferencesButton);
            Controls.Add(ApplyButton);
            Controls.Add(StartupLabel);
            Controls.Add(StartupCheckboxList);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PreferencesWindow";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox StartupCheckboxList;
        private System.Windows.Forms.Label StartupLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button ClosePreferencesButton;
        private System.Windows.Forms.ComboBox BrowserChoice;
        private System.Windows.Forms.Label BrowserLabel;
        private System.Windows.Forms.Label BehaviorLabel;
        private System.Windows.Forms.CheckBox SlowStartOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LogLevelChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomLocationDisplay;
        private System.Windows.Forms.Button customLocationClear;
        private System.Windows.Forms.Button CustomLocationBrowse;
    }
}