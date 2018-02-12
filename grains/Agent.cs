using System;
using System.Dynamic;
using System.Threading.Tasks;
using interfaces;
using Orleans;
using classes;

namespace Name
{
    class AgentGrain: Grain, IAgent
    {
        private IConversation Conversation;
        private INLU NLU;
        private AgentProperties AgentProperties;
        public override async Task OnActivateAsync()
        {
            if(AgentProperties != null){
                // Getting the reference for the Conversation Grain
                Conversation = this.GrainFactory.GetGrain<IConversation>(AgentProperties.ConversationKey);

                // Setting the credentials for the Conversation Grain
                await Conversation.SetProperties(new ConversationProperties{
                    ConversationPass = AgentProperties.ConversationPass,
                    ConversationWorkspace = AgentProperties.ConversationWorkspace
                });

                // Getting the reference for the NLU Grain
                NLU = this.GrainFactory.GetGrain<INLU>(AgentProperties.NLUKey);

                // Setting the credentials for the NLU Grain
                await NLU.SetProperties( new NLUProperties{
                    NLUPass = AgentProperties.NLUPass,
                    URL = AgentProperties.NLUURL
                });
            }
            await base.OnActivateAsync();
        }
        public async Task SetProperties(AgentProperties properties){
            AgentProperties = properties;
            await OnActivateAsync();
        }
        public Task<AgentProperties> GetProperties(){
            return Task.FromResult(AgentProperties);
        }
        public async Task<MessageResult> SendMessage(string message)
        {
            if(Conversation != null)
            {
                //MessageResult msg =  await Conversation.Message(message);
                MessageResult msg = new MessageResult();
                msg.Success = true;
                msg.Metadata = await NLU.GetCommandMetadata(message);
                return msg;
            }
            MessageResult errorMessage = new MessageResult();
            errorMessage.Success = false;
            errorMessage.Output = "I can't access my Rules Engine process";
            return errorMessage;
        }
    }
}