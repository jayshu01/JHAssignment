using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterDemo.Classes;
using Tweetinvi;

namespace TwitterDemo
{
    public partial class frmTwitter : Form
    {
        TwitterContext twitterContext = null;
        public frmTwitter()
        {
            InitializeComponent();
        }

        private void frmTwitter_Load(object sender, EventArgs e)
        {
            tabTwitter.SelectedIndexChanged += TabTwitter_SelectedIndexChangedAsync;
        }

        private void TabTwitter_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            var selectedTab = (TabControl)sender;
            switch (selectedTab.SelectedIndex)
            {
                case 1:
                    twitterContext = new TwitterContext(new TotalTweets());
                    break;
                case 2:
                    twitterContext = new TwitterContext(new AverageTweets());
                    break;
            }
            var x = Task.Run(async () => await twitterContext.GetTotalAverageFeed());
        }
    }
}
