using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackBotMessages;
using SlackBotMessages.Models;

namespace SlackMessaging
{
    class Program
    {
        private static string WebHookUrl;

        static void Main(string[] args)
        {
            var client = new SbmClient("https://hooks.slack.com/services/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");

            var message = new Message
            {
                //{ Console.WriteLine("Enter integer") },
                Username = Console.ReadLine(),
                //Text = Console.ReadLine(),
                Text = Console.ReadLine(),
                IconEmoji = Emoji.Alien,
            };

            client.Send(message);

            //SBMClient client = new SBMClient("https://hooks.slack.com/services/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");
        }

    }
}
