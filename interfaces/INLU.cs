using System;
using System.Threading.Tasks;
using classes;

namespace interfaces
{
    public interface INLU : Orleans.IGrainWithStringKey
    {
        Task SetProperties(NLUProperties properties);
        Task<NLUProperties> GetProperties();
        Task<CommandMetadata> GetCommandMetadata(string message);
    }
}