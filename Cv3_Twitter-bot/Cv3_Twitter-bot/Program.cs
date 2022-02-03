using System;
using System.IO;
using Tweetinvi;
using Tweetinvi.Models;
using System.Threading.Tasks;

namespace Cv3_Twitter_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string APIKey = "1C349dRR86oqNYUXm959a9Y44";
            string APISecret = "DnSHCRKK5dCzqw31TYSfqF77q1JmYQ9gbz41UrffI8FICeiMyh";
            string AccessToken = "1205458880593039362-kgWXTvvUfIXazA6JD3MVao9B33KbdN";
            string AccessSecret = "r449nQ5E09lRtmtzXcr9Fr8tJIbKQoArlULQzEZjKpnIq";

            byte[] ImageBytes = File.ReadAllBytes("snoop.jpg");
            TwitterClient UserClient = new TwitterClient(APIKey, APISecret, AccessToken, AccessSecret);

            IMedia ImageIMedia = await UserClient.Upload.UploadTweetImageAsync(ImageBytes);
        }
    }
}
