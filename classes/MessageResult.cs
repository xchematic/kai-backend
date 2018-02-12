using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace classes
{
    public class MessageResult
    {
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Input { get; set; }

        [JsonProperty("intents", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Intents { get; set; }

        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Entities { get; set; }
        
        [JsonProperty("alternate_intents", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic AlternateIntents { get; set; }
        
        [JsonProperty("context", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Context { get; set; }
        
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Output { get; set; }
        
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool Success {get;set;}
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Metadata {get;set;}
    }
}