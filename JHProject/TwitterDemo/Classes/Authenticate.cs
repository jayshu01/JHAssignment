using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace TwitterDemo.Classes
{
    public static class Authenticate
    {
        private const string CONSUMERKEY = "";
        private const string CONSUMERSECRET = "";
        private const string ACCESSTOKEN = "";
        private const string ACCESSSECRET = "";
        private static TwitterClient twitterClient;
        private static async Task<IAuthenticatedUser> IsAuthenticated()
        {
            twitterClient = new TwitterClient(CONSUMERKEY, CONSUMERSECRET, ACCESSTOKEN, ACCESSSECRET);
            return await twitterClient.Users.GetAuthenticatedUserAsync();
        }

        public static async Task<TwitterClient> GetTwitterClientAsync()
        {
            var a = await IsAuthenticated();
            if (a != null)
            {
                return twitterClient;
            }
            return null;
        }
    }
}
