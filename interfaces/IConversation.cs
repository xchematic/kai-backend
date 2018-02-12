using System;
using System.Threading.Tasks;
using classes;
using Orleans;

namespace interfaces
{
    public interface IConversation : IGrainWithStringKey
    {
        Task<MessageResult> Message(string param);
        Task SetProperties(ConversationProperties properties);
    }
}
