namespace CryptaTray
{
    partial class CrashDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashDialog));
            IconBox = new System.Windows.Forms.PictureBox();
            crashMessageLabel = new System.Windows.Forms.Label();
            ViewLogButton = new System.Windows.Forms.Button();
            SupportChatButton = new System.Windows.Forms.Button();
            MailingListButton = new System.Windows.Forms.Button();
            RestartButton = new System.Windows.Forms.Button();
            CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)IconBox).BeginInit();
            SuspendLayout();
            // 
            // IconBox
            // 
            resources.ApplyResources(IconBox, "IconBox");
            IconBox.Name = "IconBox";
            IconBox.TabStop = false;
            // 
            // crashMessageLabel
            // 
            resources.ApplyResources(crashMessageLabel, "crashMessageLabel");
            crashMessageLabel.Name = "crashMessageLabel";
            // 
            // ViewLogButton
            // 
            resources.ApplyResources(ViewLogButton, "ViewLogButton");
            ViewLogButton.Name = "ViewLogButton";
            ViewLogButton.UseVisualStyleBackColor = true;
            ViewLogButton.Click += ViewLogButton_Click;
            // 
            // SupportChatButton
            // 
            resources.ApplyResources(SupportChatButton, "SupportChatButton");
            SupportChatButton.Name = "SupportChatButton";
            SupportChatButton.UseVisualStyleBackColor = true;
            SupportChatButton.Click += SupportChatButton_Click;
            // 
            // MailingListButton
            // 
            resources.ApplyResources(MailingListButton, "MailingListButton");
            MailingListButton.Name = "MailingListButton";
            MailingListButton.UseVisualStyleBackColor = true;
            MailingListButton.Click += MailingListButton_Click;
            // 
            // RestartButton
            // 
            resources.ApplyResources(RestartButton, "RestartButton");
            RestartButton.Name = "RestartButton";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(CloseButton, "CloseButton");
            CloseButton.Name = "CloseButton";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // CrashDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = CloseButton;
            Controls.Add(CloseButton);
            Controls.Add(RestartButton);
            Controls.Add(MailingListButton);
            Controls.Add(SupportChatButton);
            Controls.Add(ViewLogButton);
            Controls.Add(crashMessageLabel);
            Controls.Add(IconBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrashDialog";
            Load += CrashDialog_Load;
            ((System.ComponentModel.ISupportInitialize)IconBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label crashMessageLabel;
        private System.Windows.Forms.Button ViewLogButton;
        private System.Windows.Forms.Button SupportChatButton;
        private System.Windows.Forms.Button MailingListButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button CloseButton;
    }
}