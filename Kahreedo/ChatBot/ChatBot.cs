//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Khareedo.ChatBot
{
    public class ChatBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            // Handle incoming messages from the user
            // Implement your chatbot logic here
        }
    }
}