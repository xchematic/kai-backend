using System;
using System.Dynamic;
using System.Threading.Tasks;
using interfaces;
using IBM.WatsonDeveloperCloud.Conversation.v1;
using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using classes;
using Orleans;

namespace grains
{
    public class ConversationGrain : Grain, IConversation
    {
        private ConversationService kaiconversation;
        private ConversationProperties ConversationProperties;

        public override async Task OnActivateAsync()
        {
            if(ConversationProperties != null && !String.IsNullOrEmpty(ConversationProperties.ConversationPass))
            {
                string ConversationKey;
                this.GetPrimaryKey(out ConversationKey);
                kaiconversation = new ConversationService(ConversationKey, ConversationProperties.ConversationPass, ConversationService.CONVERSATION_VERSION_DATE_2017_05_26);
            }
            await base.OnActivateAsync();
        }

        public async Task SetProperties(ConversationProperties properties)
        {
            ConversationProperties = properties;
            await OnActivateAsync();
        }
        public Task<MessageResult> Message(string param)
        {
            MessageResult response = new MessageResult();
            if(kaiconversation != null)
            {
                MessageRequest request = new MessageRequest()
                {
                    Input = new InputData()
                    {
                        Text = param
                    }
                };

                MessageResponse result = kaiconversation.Message(ConversationProperties.ConversationWorkspace, request);
                //return Task.FromResult(string.Format("result: {0}", JsonConvert.SerializeObject(result, Formatting.Indented)));
                response.Success = true;
                response.Output = result.Output;
                return Task.FromResult(response);
            }
            
            response.Success = false;
            response.Output = "My conversation service is not properly configured";
            return Task.FromResult(response);
        }
    }
}
