using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterDemo.Interfaces
{
    /// <summary>
    /// Interface to handle different requirements for tweets
    /// </summary>
    public interface ITwitterFeed
    {
        Task<Tweetinvi.Models.ITweet> RetrieveCount();
    }
}
