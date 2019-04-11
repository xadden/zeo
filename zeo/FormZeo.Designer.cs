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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.watcher = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonManageSeries = new System.Windows.Forms.Button();
            this.buttonSpecificEpisode = new System.Windows.Forms.Button();
            this.buttonRefreshFeed = new System.Windows.Forms.Button();
            this.buttonLaunchTorrent = new System.Windows.Forms.Button();
            this.listBoxOfEpisodes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCompletedTorrent = new System.Windows.Forms.TextBox();
            this.buttonCompletedTorrentPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDownloadedEpisode = new System.Windows.Forms.TextBox();
            this.buttonDownloadedEpisodesPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTorrentApp = new System.Windows.Forms.TextBox();
            this.buttonTorrentPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Zeo";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxOfEpisodes);
            this.groupBox1.Controls.Add(this.buttonManageSeries);
            this.groupBox1.Controls.Add(this.buttonSpecificEpisode);
            this.groupBox1.Controls.Add(this.buttonRefreshFeed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 284);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Episodes";
            // 
            // buttonManageSeries
            // 
            this.buttonManageSeries.Location = new System.Drawing.Point(6, 253);
            this.buttonManageSeries.Name = "buttonManageSeries";
            this.buttonManageSeries.Size = new System.Drawing.Size(168, 23);
            this.buttonManageSeries.TabIndex = 4;
            this.buttonManageSeries.Text = "Manage Series";
            this.buttonManageSeries.UseVisualStyleBackColor = true;
            this.buttonManageSeries.Click += new System.EventHandler(this.buttonManageSeries_Click);
            // 
            // buttonSpecificEpisode
            // 
            this.buttonSpecificEpisode.Location = new System.Drawing.Point(180, 253);
            this.buttonSpecificEpisode.Name = "buttonSpecificEpisode";
            this.buttonSpecificEpisode.Size = new System.Drawing.Size(156, 23);
            this.buttonSpecificEpisode.TabIndex = 5;
            this.buttonSpecificEpisode.Text = "Search Specific Episode";
            this.buttonSpecificEpisode.UseVisualStyleBackColor = true;
            this.buttonSpecificEpisode.Click += new System.EventHandler(this.buttonSpecificEpisode_Click);
            // 
            // buttonRefreshFeed
            // 
            this.buttonRefreshFeed.Location = new System.Drawing.Point(6, 224);
            this.buttonRefreshFeed.Name = "buttonRefreshFeed";
            this.buttonRefreshFeed.Size = new System.Drawing.Size(330, 23);
            this.buttonRefreshFeed.TabIndex = 2;
            this.buttonRefreshFeed.Text = "Refresh Following Series";
            this.buttonRefreshFeed.UseVisualStyleBackColor = true;
            this.buttonRefreshFeed.Click += new System.EventHandler(this.buttonRefreshFeed_Click);
            // 
            // buttonLaunchTorrent
            // 
            this.buttonLaunchTorrent.Location = new System.Drawing.Point(9, 253);
            this.buttonLaunchTorrent.Name = "buttonLaunchTorrent";
            this.buttonLaunchTorrent.Size = new System.Drawing.Size(309, 23);
            this.buttonLaunchTorrent.TabIndex = 7;
            this.buttonLaunchTorrent.Text = "Launch Torrent";
            this.buttonLaunchTorrent.UseVisualStyleBackColor = true;
            this.buttonLaunchTorrent.Click += new System.EventHandler(this.buttonLaunchTorrent_Click);
            // 
            // listBoxOfEpisodes
            // 
            this.listBoxOfEpisodes.FormattingEnabled = true;
            this.listBoxOfEpisodes.Location = new System.Drawing.Point(6, 19);
            this.listBoxOfEpisodes.Name = "listBoxOfEpisodes";
            this.listBoxOfEpisodes.Size = new System.Drawing.Size(330, 199);
            this.listBoxOfEpisodes.TabIndex = 0;
            this.listBoxOfEpisodes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOfAnimes_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTorrentApp);
            this.groupBox2.Controls.Add(this.buttonTorrentPath);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDownloadedEpisode);
            this.groupBox2.Controls.Add(this.buttonDownloadedEpisodesPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxCompletedTorrent);
            this.groupBox2.Controls.Add(this.buttonLaunchTorrent);
            this.groupBox2.Controls.Add(this.buttonCompletedTorrentPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 284);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // textBoxCompletedTorrent
            // 
            this.textBoxCompletedTorrent.Location = new System.Drawing.Point(9, 35);
            this.textBoxCompletedTorrent.Name = "textBoxCompletedTorrent";
            this.textBoxCompletedTorrent.ReadOnly = true;
            this.textBoxCompletedTorrent.Size = new System.Drawing.Size(309, 20);
            this.textBoxCompletedTorrent.TabIndex = 5;
            // 
            // buttonCompletedTorrentPath
            // 
            this.buttonCompletedTorrentPath.Location = new System.Drawing.Point(9, 61);
            this.buttonCompletedTorrentPath.Name = "buttonCompletedTorrentPath";
            this.buttonCompletedTorrentPath.Size = new System.Drawing.Size(309, 23);
            this.buttonCompletedTorrentPath.TabIndex = 4;
            this.buttonCompletedTorrentPath.Text = "Change";
            this.buttonCompletedTorrentPath.UseVisualStyleBackColor = true;
            this.buttonCompletedTorrentPath.Click += new System.EventHandler(this.buttonCompletedTorrentPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Completed Torrents Path";
            // 
            // textBoxDownloadedEpisode
            // 
            this.textBoxDownloadedEpisode.Location = new System.Drawing.Point(9, 115);
            this.textBoxDownloadedEpisode.Name = "textBoxDownloadedEpisode";
            this.textBoxDownloadedEpisode.ReadOnly = true;
            this.textBoxDownloadedEpisode.Size = new System.Drawing.Size(309, 20);
            this.textBoxDownloadedEpisode.TabIndex = 10;
            // 
            // buttonDownloadedEpisodesPath
            // 
            this.buttonDownloadedEpisodesPath.Location = new System.Drawing.Point(9, 141);
            this.buttonDownloadedEpisodesPath.Name = "buttonDownloadedEpisodesPath";
            this.buttonDownloadedEpisodesPath.Size = new System.Drawing.Size(309, 23);
            this.buttonDownloadedEpisodesPath.TabIndex = 9;
            this.buttonDownloadedEpisodesPath.Text = "Change";
            this.buttonDownloadedEpisodesPath.UseVisualStyleBackColor = true;
            this.buttonDownloadedEpisodesPath.Click += new System.EventHandler(this.buttonDownloadedEpisodesPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Save Path";
            // 
            // textBoxTorrentApp
            // 
            this.textBoxTorrentApp.Location = new System.Drawing.Point(9, 198);
            this.textBoxTorrentApp.Name = "textBoxTorrentApp";
            this.textBoxTorrentApp.ReadOnly = true;
            this.textBoxTorrentApp.Size = new System.Drawing.Size(309, 20);
            this.textBoxTorrentApp.TabIndex = 13;
            // 
            // buttonTorrentPath
            // 
            this.buttonTorrentPath.Location = new System.Drawing.Point(9, 224);
            this.buttonTorrentPath.Name = "buttonTorrentPath";
            this.buttonTorrentPath.Size = new System.Drawing.Size(309, 23);
            this.buttonTorrentPath.TabIndex = 12;
            this.buttonTorrentPath.Text = "Change";
            this.buttonTorrentPath.UseVisualStyleBackColor = true;
            this.buttonTorrentPath.Click += new System.EventHandler(this.buttonTorrentPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Torrent Application Path";
            // 
            // Zeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 304);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Zeo";
            this.Text = "Zeo";
            this.Load += new System.EventHandler(this.Zeo_Load);
            this.Resize += new System.EventHandler(this.Zeo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxOfEpisodes;
        private System.Windows.Forms.Button buttonLaunchTorrent;
        private System.Windows.Forms.Button buttonManageSeries;
        private System.Windows.Forms.Button buttonSpecificEpisode;
        private System.Windows.Forms.Button buttonRefreshFeed;
        private System.Windows.Forms.TextBox textBoxTorrentApp;
        private System.Windows.Forms.Button buttonTorrentPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDownloadedEpisode;
        private System.Windows.Forms.Button buttonDownloadedEpisodesPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompletedTorrent;
        private System.Windows.Forms.Button buttonCompletedTorrentPath;
        private System.Windows.Forms.Label label1;
    }
}

