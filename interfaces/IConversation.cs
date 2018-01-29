using System;
using System.Threading.Tasks;
using classes;

namespace interfaces
{
    public interface IConversation : Orleans.IGrainWithStringKey
    {
        Task<string> Message(string param);
        Task SetProperties(ConversationProperties properties);
    }
}
