using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using Zeo;
using Zeo.Episode;
using Zeo.Properties;
using System.ServiceModel.Syndication;

namespace FormZeo {
    public partial class Zeo : Form {
        string rssUrl = "http://horriblesubs.info/rss.php?res=1080";
        string nyaaUrl = "https://nyaa.si/?f=0&c=0_0&q=Horriblesubs 1080 %search%&page=rss&magnets";
        private static System.Timers.Timer timerCheckEpisodes;
        private string[] followingSeries = null;
        string followingSeriesPath = null;


        /* TODO List:
         * Save and read downloadedEpisodes from file
         * Change rss feed, option to choose anime or tv shows
         * Add warnings when missing configurations
         */

        public Zeo() {
            InitializeComponent();
            SetTimer();
        }

        /* 
         * Get feed from rss feed
         */
        private List<Episode> getFeed() {
            List<Episode> episodes = new List<Episode>();

            XmlReader reader = XmlReader.Create(rssUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            string title = null;

            foreach (SyndicationItem item in feed.Items) {
                title = item.Title.Text.Replace("[HorribleSubs]", "").Replace("[1080p].mkv", "");
                if (followingSeries != null) {
                    foreach (String series in followingSeries)
                        if (title.ToUpper().Contains(series.ToUpper()))
                            episodes.Add(new Episode(title, item.Links[0].Uri.ToString()));
                } else
                    episodes.Add(new Episode(title, item.Links[0].Uri.ToString()));
            }

            return episodes;
        }

        /* 
         * Read followingSeries file and downloadedSeries File
         * File is located in the folder %appdata%\Zeo
         */
        private void readSeriesFiles() {
            if(followingSeriesPath == null)
                followingSeriesPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zeo\\followingSeries.dat";

            if (File.Exists(followingSeriesPath))
                    followingSeries = File.ReadAllLines(followingSeriesPath);
        }

        /* 
         * Refresh feed of listboxOfEpisodes
         */
        private void refreshFeed() {
            listBoxOfEpisodes.Items.Clear();
            List<Episode> episodes = getFeed();
            foreach (Episode episode in episodes)
                listBoxOfEpisodes.Items.Add(episode);
        }

        private void Zeo_Load(object sender, EventArgs e) {
            readSeriesFiles();

            List<Episode> episodes = getFeed();
            foreach (Episode episode in episodes)
                listBoxOfEpisodes.Items.Add(episode);

            textBoxCompletedTorrent.Text = Settings.Default.completedTorrentsPath;
            textBoxDownloadedEpisode.Text = Settings.Default.saveTorrentsPath;
            textBoxTorrentApp.Text = Settings.Default.torrentPath;

            #region FileSystemWatcher Configuration
            watcher.Path = @"D:\Torrents\Completed";
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;
            watcher.Filter = "*[HorribleSubs]*.mkv";
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
            #endregion
        }

        /*
         * Moves downloaded episodes from one path to another and organizes by name
         * TODO add warning saying paths are not set
         */ 
        private void OnChanged(object source, FileSystemEventArgs e) {
            if(!string.IsNullOrEmpty(Settings.Default.completedTorrentsPath) && !string.IsNullOrEmpty(Settings.Default.saveTorrentsPath)) {
                string folder;
                int start;

                folder = e.Name.Replace("[HorribleSubs] ", "");
                start = folder.IndexOf(" - ");
                folder = folder.Remove(start, folder.Length - start); //Remove everything after ' - ' is found

                string completedFolderPath = Settings.Default.completedTorrentsPath + System.IO.Path.DirectorySeparatorChar + e.Name;
                string saveFolderPath = Settings.Default.saveTorrentsPath + System.IO.Path.DirectorySeparatorChar + folder;
                string saveFilePath = Settings.Default.saveTorrentsPath + System.IO.Path.DirectorySeparatorChar + folder + System.IO.Path.DirectorySeparatorChar + e.Name;

                Directory.CreateDirectory(saveFolderPath); //if folder already exists, it will be ignored
                File.Move(completedFolderPath, saveFilePath);
            }
        }

        /* 
         * Schedule task every 1hr
         */
        private void SetTimer() {
            timerCheckEpisodes = new System.Timers.Timer(3600000); // Change to 3600000 = 1hr
            timerCheckEpisodes.Elapsed += OnTimedEvent;
            timerCheckEpisodes.AutoReset = true;
            timerCheckEpisodes.Enabled = true;
        }

        /* 
         * Scheduled task
         */
        private void OnTimedEvent(Object source, ElapsedEventArgs e) {
            List<Episode> episodes = getFeed();
            foreach (Episode episode in episodes)
                this.Invoke(new MethodInvoker(() => listBoxOfEpisodes.Items.Add(episode)));
            // check for new feed and refresh
        }

        /* 
         * Double click on listbox item uses magnet link
         */
        private void listBoxOfAnimes_MouseDoubleClick(object sender, MouseEventArgs e) {
            Episode episode = (Episode)listBoxOfEpisodes.SelectedItem;
            Process.Start(episode.url);
        }

        /* 
         * Button to refresh feed manually
         */
        private void buttonRefreshFeed_Click(object sender, EventArgs e) {
            refreshFeed();
        }

        /* 
         * On minimize send to system tray
         */
        private void Zeo_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        /*
         * Double click on system tray icon makes form visible
         */
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        /*
         * Open ManageSeries form
         */
        private void buttonManageSeries_Click(object sender, EventArgs e) {
            FormManageSeries form = new FormManageSeries();
            form.followingSeries = followingSeries;
            form.path = followingSeriesPath;
            if (form.ShowDialog() == DialogResult.OK) {
                followingSeries = form.updatedList;
                form.Dispose();
            }

            refreshFeed();
        }

        /*
         * Search for a specific episode
         * Could be more generic by asking for rss url
         */
        private void buttonSpecificEpisode_Click(object sender, EventArgs e) {
            FormInputModal form = new FormInputModal();
            if (form.ShowDialog() == DialogResult.OK) {
                List<Episode> episodes = new List<Episode>();

                XmlReader reader = XmlReader.Create(nyaaUrl.Replace("%search%", form.input));
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                string title = null;
                foreach (SyndicationItem item in feed.Items) {
                    title = item.Title.Text.Replace("[HorribleSubs]", "").Replace("[1080p].mkv", "");
                    episodes.Add(new Episode(title, item.Links[0].Uri.ToString()));
                }

                listBoxOfEpisodes.Items.Clear();
                foreach (Episode episode in episodes)
                    listBoxOfEpisodes.Items.Add(episode);
            }

            form.Dispose();
        }

        /*
         * Open torrent
         * TODO: Let user choose it's own torrent
         */ 
        private void buttonLaunchTorrent_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(Settings.Default.torrentPath))
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Deluge\deluge.exe");
            else
                MessageBox.Show("Define torrent path first in the settings.");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonCompletedTorrentPath_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
                if (folder.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath)) {
                    Settings.Default.completedTorrentsPath = folder.SelectedPath;
                    Settings.Default.Save();
                    textBoxCompletedTorrent.Text = folder.SelectedPath;
                }
        }

        private void buttonDownloadedEpisodesPath_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
                if (folder.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath)) {
                    Settings.Default.saveTorrentsPath = folder.SelectedPath;
                    Settings.Default.Save();
                    textBoxDownloadedEpisode.Text = folder.SelectedPath;
                }
        }

        private void buttonTorrentPath_Click(object sender, EventArgs e) {
            using (OpenFileDialog file = new OpenFileDialog())
                if (file.ShowDialog() == DialogResult.OK) {
                    Settings.Default.torrentPath = file.FileName;
                    Settings.Default.Save();
                    textBoxTorrentApp.Text = file.FileName;
                }
        }
    }
}
