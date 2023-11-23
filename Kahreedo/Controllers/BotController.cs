using Khareedo.Models;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Bot.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using Microsoft.Bot.Builder;
using Amazon.LexRuntimeV2.Model;
using Amazon.Runtime;
using Amazon.LexRuntimeV2;
using Amazon;




namespace Khareedo.Controllers
{
    public class BotController : Controller
    {
        private AmazonLexRuntimeV2Client lexClient;
        public BotController()
        {
            var awsCredentials = new BasicAWSCredentials("AKIAR5ZSWCZUOANO4IX3", "t+uNRuOQSgYAL7ggQ6x2GCHUzHui+5wVuDmBnePS");
            var lexConfig = new AmazonLexRuntimeV2Config
            {
                RegionEndpoint = RegionEndpoint.USEast1 // Replace with your desired region
            };

            lexClient = new AmazonLexRuntimeV2Client(awsCredentials, lexConfig);
        }

        [HttpPost]
        public ActionResult SendMessage(string message)
        {
            string sessionId = "userId123";
            var request = new RecognizeTextRequest
            {
                BotId = "D61WKXISZ5",
                BotAliasId = "OUNCNU6SSM",
                LocaleId = "en_US",
                SessionId= sessionId,
            Text = message
            };

            var response = lexClient.RecognizeText(request);
            var botMessage = response.Messages.FirstOrDefault()?.Content;

            return Json(botMessage);
        }
    }
}