using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using interfaces;

namespace grains
{
    public class ConversationGrain : Orleans.Grain, IConversation
    {
        private readonly ILogger logger;
        public ConversationGrain(ILogger<ConversationGrain> logger)
        {
            this.logger = logger;
        }
        public Task<string> Message(string param)
        {
            return Task.FromResult($@"Your message is: {param}");
        }
    }
}
