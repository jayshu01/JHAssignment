using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterDemo.Interfaces;
using Tweetinvi;
using Tweetinvi.Models;
namespace TwitterDemo.Classes
{
    /// <summary>
    /// Returns the average tweets
    /// </summary>
    public class AverageTweets : ITwitterFeed
    {
        Task<ITweet> ITwitterFeed.RetrieveCount()
        {
            return null;
        }
    }
}
