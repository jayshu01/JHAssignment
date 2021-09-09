using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;
using Tweetinvi.Models;
using TwitterDemo.Interfaces;

namespace TwitterDemo.Classes
{
    public class TotalTweets : ITwitterFeed
    {
        public async Task<ITweet> RetrieveCount()
        {
            TwitterClient tc = await GetTwitterClientAsync();
            var tweet = await Task.Run(() => tc.Tweets.PublishTweetAsync("Hello World, first tweet from code!."));
            return tweet;
        }

        private async Task<TwitterClient> GetTwitterClientAsync()
        {
           return await Task.Run(() => Authenticate.GetTwitterClientAsync());
        }
    }
}
