using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using Zeo;
using Zeo.Episode;
using System.ServiceModel.Syndication;

namespace FormZeo {
    public partial class Zeo : Form {
        string rssUrl = "http://horriblesubs.info/rss.php?res=1080";
        string nyaaUrl = "https://nyaa.si/?f=0&c=0_0&q=Horriblesubs 1080 %search%&page=rss";
        private static System.Timers.Timer timerCheckEpisodes;
        private string[] followingSeries = null;
        string fileFollowingSeries = null;


        /* TODO List:
         * Save files in %appdata%\Zeo
         * Save and read downloadedEpisodes from file
         * Change rss feed, option to choose anime or tv shows
         * 
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
            if (followingSeries != null) {
                foreach (SyndicationItem item in feed.Items) {
                    title = item.Title.Text.Replace("[HorribleSubs]", "").Replace("[1080p].mkv", "");
                    foreach (String series in followingSeries)
                        if (title.ToUpper().Contains(series.ToUpper()))
                            episodes.Add(new Episode(title, item.Links[0].Uri.ToString()));
                }
            } else
                foreach (SyndicationItem item in feed.Items) {
                    title = item.Title.Text.Replace("[HorribleSubs]", "").Replace("[1080p].mkv", "");
                    episodes.Add(new Episode(title, item.Links[0].Uri.ToString()));
                }

            return episodes;
        }

        /* 
         * Read followingSeries file and downloadedSeries File
         * File is located in the folder %appdata%\Zeo
         */
        private void readSeriesFiles() {
            fileFollowingSeries = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Zeo\\followingSeries.dat";

            if (File.Exists(fileFollowingSeries))
                followingSeries = File.ReadAllLines(fileFollowingSeries);
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
            form.path = fileFollowingSeries;
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
    }
}
