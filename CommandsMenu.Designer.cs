namespace CryptaTray
{
    partial class CommandsMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandsMenu));
            trayIcon = new System.Windows.Forms.NotifyIcon(components);
            contextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            openFreenetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            startFreenetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            stopFreenetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            downloadsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewLogsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            preferencesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hideIconMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = contextMenu;
            resources.ApplyResources(trayIcon, "trayIcon");
            trayIcon.MouseClick += trayIcon_MouseClick;
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openFreenetMenuItem, toolStripSeparator2, startFreenetMenuItem, stopFreenetMenuItem, downloadsMenuItem, viewLogsMenuItem, toolStripSeparator1, preferencesMenuItem, hideIconMenuItem, exitMenuItem });
            contextMenu.Name = "contextMenu";
            resources.ApplyResources(contextMenu, "contextMenu");
            // 
            // openFreenetMenuItem
            // 
            resources.ApplyResources(openFreenetMenuItem, "openFreenetMenuItem");
            openFreenetMenuItem.Name = "openFreenetMenuItem";
            openFreenetMenuItem.Click += openCryptaMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
            // 
            // startFreenetMenuItem
            // 
            resources.ApplyResources(startFreenetMenuItem, "startFreenetMenuItem");
            startFreenetMenuItem.Name = "startFreenetMenuItem";
            startFreenetMenuItem.Click += startCryptaMenuItem_Click;
            // 
            // stopFreenetMenuItem
            // 
            resources.ApplyResources(stopFreenetMenuItem, "stopFreenetMenuItem");
            stopFreenetMenuItem.Name = "stopFreenetMenuItem";
            stopFreenetMenuItem.Click += stopCryptaMenuItem_Click;
            // 
            // downloadsMenuItem
            // 
            resources.ApplyResources(downloadsMenuItem, "downloadsMenuItem");
            downloadsMenuItem.Name = "downloadsMenuItem";
            downloadsMenuItem.Click += downloadsMenuItem_Click;
            // 
            // viewLogsMenuItem
            // 
            resources.ApplyResources(viewLogsMenuItem, "viewLogsMenuItem");
            viewLogsMenuItem.Name = "viewLogsMenuItem";
            viewLogsMenuItem.Click += viewLogsMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            // 
            // preferencesMenuItem
            // 
            preferencesMenuItem.Name = "preferencesMenuItem";
            resources.ApplyResources(preferencesMenuItem, "preferencesMenuItem");
            preferencesMenuItem.Click += preferencesMenuItem_Click;
            // 
            // hideIconMenuItem
            // 
            resources.ApplyResources(hideIconMenuItem, "hideIconMenuItem");
            hideIconMenuItem.Name = "hideIconMenuItem";
            hideIconMenuItem.Click += hideIconMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            resources.ApplyResources(exitMenuItem, "exitMenuItem");
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // CommandsMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "CommandsMenu";
            ShowInTaskbar = false;
            WindowState = System.Windows.Forms.FormWindowState.Minimized;
            Load += CommandsMenu_Load;
            contextMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem openFreenetMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startFreenetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopFreenetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLogsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideIconMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadsMenuItem;
    }
}

