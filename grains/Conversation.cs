using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using interfaces;
using IBM.WatsonDeveloperCloud.Conversation.v1;
using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using Newtonsoft.Json;

namespace grains
{
    public class ConversationGrain : Orleans.Grain, IConversation
    {
        private readonly ILogger logger;
        private ConversationService kaiconversation;
        public ConversationGrain(ILogger<ConversationGrain> logger)
        {
            this.logger = logger;
            kaiconversation = new ConversationService("ac1662c2-bc78-4474-8759-014ddca87611","LnqVZHFa47a7", ConversationService.CONVERSATION_VERSION_DATE_2017_05_26);
        }
        public Task<string> Message(string param)
        {
            MessageRequest request = new MessageRequest()
            {
                Input = new InputData()
                {
                    Text = param
                }
            };

            MessageResponse result = kaiconversation.Message("314571e1-d570-4127-9682-8cda467d6f42", request);

            return Task.FromResult(string.Format("result: {0}", JsonConvert.SerializeObject(result, Formatting.Indented)));
        }
    }
}
