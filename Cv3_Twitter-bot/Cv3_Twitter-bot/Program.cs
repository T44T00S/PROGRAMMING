using System;
using System.IO;
using Tweetinvi;
using Tweetinvi.Models;
using System.Threading.Tasks;
using Tweetinvi.Parameters;

namespace Cv3_Twitter_bot
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Random RandNum = new Random();
            string[] SnoopQuotes =
            {
                "Gimme the microphone first, so I can bust like a bubble",
                "Ready to make an entrance, so back on up ('Cause you know we're 'bout to rip shit up)",
                "Snoop Doggy Dogg and Dr. Dre is at the Door.",
                "1 2 3 and to the 4.",
                "Smokin n Coding.",
                "Buy Low . . . Stay High!!",
                "PuffPUFFPass",
                "My mind on my money, my money on my mind.",
                "Drop it like it’s hot.",
                "The more medicated the more dedicated.",
                "You don’t get respect if you don’t deserve it.",
                "It ain’t no fun if the homies can’t have none."
            };

            string APIKey = "1C349dRR86oqNYUXm959a9Y44";
            string APISecret = "DnSHCRKK5dCzqw31TYSfqF77q1JmYQ9gbz41UrffI8FICeiMyh";
            string AccessToken = "1205458880593039362-kgWXTvvUfIXazA6JD3MVao9B33KbdN";

            //string AccessSecret = "r449nQ5E09lRtmtzXcr9Fr8tJIbKQoArlULQzEZjKpnIq";

            byte[] ImageBytes = File.ReadAllBytes("snoop.jpg");
            TwitterClient UserClient = new TwitterClient(APIKey, APISecret);



            IMedia ImageIMedia = await UserClient.Upload.UploadTweetImageAsync(ImageBytes);
            ITweet TweetWithImage = await UserClient.Tweets.PublishTweetAsync(new PublishTweetParameters(SnoopQuotes[RandNum.Next(10)] + "#ZemanNaUlici #ItIsWhatItIs #CyberMeansPrestige") { Medias = { ImageIMedia }});
        }
    }
}
