using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tweetinvi;
using Tweetinvi.Models;
using System.Threading.Tasks;
using TwitterDemo.Interfaces;

namespace TwitterDemo.Classes
{
    /// <summary>
    /// Context class to handle the strategy pattern
    /// </summary>
    public class TwitterContext
    {
        private ITwitterFeed _twitterFeed;

        /// <summary>
        /// This constructor is not needed if DI is implemented. 
        /// Now just to avoid the parameterless constructor issue adding
        /// </summary>
        public TwitterContext() { }

        /// <summary>
        /// Constructor using Interface (DI using constructor)
        /// </summary>
        /// <param name="twitterFeed"></param>
        public TwitterContext(ITwitterFeed twitterFeed)
        {
            this._twitterFeed = twitterFeed;
        }

        /// <summary>
        /// method called from client
        /// </summary>
        /// <returns></returns>
        public async Task<ITweet> GetTotalAverageFeed()
        {
            var getCount = await Task.Run(() => _twitterFeed.RetrieveCount());
            return getCount;
        }

    }
}
