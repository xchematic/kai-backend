using System;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IConversation : Orleans.IGrainWithIntegerKey
    {
        Task<string> Message(string param);
    }
}
