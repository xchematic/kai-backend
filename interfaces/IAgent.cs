using System;
using System.Threading.Tasks;
using classes;

namespace interfaces
{
    public interface IAgent : Orleans.IGrainWithGuidKey
    {
        Task SetProperties(AgentProperties properties);
        Task<AgentProperties> GetProperties();
        Task<MessageResult> SendMessage(string message);
    }
}