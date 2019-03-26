namespace FormZeo {
    partial class Zeo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zeo));
            this.listBoxOfEpisodes = new System.Windows.Forms.ListBox();
            this.buttonRefreshFeed = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonManageSeries = new System.Windows.Forms.Button();
            this.buttonSpecificEpisode = new System.Windows.Forms.Button();
            this.watcher = new System.IO.FileSystemWatcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOfEpisodes
            // 
            this.listBoxOfEpisodes.FormattingEnabled = true;
            this.listBoxOfEpisodes.Location = new System.Drawing.Point(12, 27);
            this.listBoxOfEpisodes.Name = "listBoxOfEpisodes";
            this.listBoxOfEpisodes.Size = new System.Drawing.Size(330, 368);
            this.listBoxOfEpisodes.TabIndex = 0;
            this.listBoxOfEpisodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOfAnimes_MouseDoubleClick);
            // 
            // buttonRefreshFeed
            // 
            this.buttonRefreshFeed.Location = new System.Drawing.Point(12, 401);
            this.buttonRefreshFeed.Name = "buttonRefreshFeed";
            this.buttonRefreshFeed.Size = new System.Drawing.Size(330, 23);
            this.buttonRefreshFeed.TabIndex = 2;
            this.buttonRefreshFeed.Text = "Refresh Following Series";
            this.buttonRefreshFeed.UseVisualStyleBackColor = true;
            this.buttonRefreshFeed.Click += new System.EventHandler(this.buttonRefreshFeed_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Zeo";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // buttonManageSeries
            // 
            this.buttonManageSeries.Location = new System.Drawing.Point(348, 27);
            this.buttonManageSeries.Name = "buttonManageSeries";
            this.buttonManageSeries.Size = new System.Drawing.Size(140, 23);
            this.buttonManageSeries.TabIndex = 4;
            this.buttonManageSeries.Text = "Manage Series";
            this.buttonManageSeries.UseVisualStyleBackColor = true;
            this.buttonManageSeries.Click += new System.EventHandler(this.buttonManageSeries_Click);
            // 
            // buttonSpecificEpisode
            // 
            this.buttonSpecificEpisode.Location = new System.Drawing.Point(348, 56);
            this.buttonSpecificEpisode.Name = "buttonSpecificEpisode";
            this.buttonSpecificEpisode.Size = new System.Drawing.Size(140, 23);
            this.buttonSpecificEpisode.TabIndex = 5;
            this.buttonSpecificEpisode.Text = "Search Specific Episode";
            this.buttonSpecificEpisode.UseVisualStyleBackColor = true;
            this.buttonSpecificEpisode.Click += new System.EventHandler(this.buttonSpecificEpisode_Click);
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            // 
            // Zeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.buttonSpecificEpisode);
            this.Controls.Add(this.buttonManageSeries);
            this.Controls.Add(this.buttonRefreshFeed);
            this.Controls.Add(this.listBoxOfEpisodes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Zeo";
            this.Text = "Zeo";
            this.Load += new System.EventHandler(this.Zeo_Load);
            this.Resize += new System.EventHandler(this.Zeo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOfEpisodes;
        private System.Windows.Forms.Button buttonRefreshFeed;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonManageSeries;
        private System.Windows.Forms.Button buttonSpecificEpisode;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
    }
}

