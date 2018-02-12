using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;
using Orleans.Runtime.Configuration;
using interfaces;
using classes;
using Newtonsoft.Json;

namespace client
{
    public class Program
    {
        static int Main(string[] args)
        {
            return RunMainAsync().Result;
        }
        private static async Task<int> RunMainAsync()
        {
            try
            {
                using(var client = await StartClientWithRetries())
                {
                    await DoClientWork(client);
                    Console.ReadKey();
                }
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return 1;
            }
        }
        public static async Task<IClusterClient> StartClientWithRetries(int initializeAttemptsBeforeFailing = 5)
        {
            int attempt = 0;
            IClusterClient client;
            while(true)
            {
                try
                {
                    var config = ClientConfiguration.LocalhostSilo();
                    client = new ClientBuilder()
                        .UseConfiguration(config)
			            .ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(IConversation).Assembly).WithReferences())
                        .ConfigureLogging(logging => logging.AddConsole())
                        .Build();
                    
                    await client.Connect();
                    Console.WriteLine("Client successfully connect to silo host");
                    break;
                }
                catch(SiloUnavailableException)
                {
                    attempt++;
                    Console.WriteLine($"Attempt {attempt} of {initializeAttemptsBeforeFailing} failed to initialize the Orleans client.");
                    if(attempt > initializeAttemptsBeforeFailing)
                    {
                        throw;
                    }
                    await Task.Delay(TimeSpan.FromSeconds(4));
                }
            }

            return client;
        }
        private static async Task DoClientWork(IClusterClient client)
        {
            AgentProperties properties = new AgentProperties()
            {
                Name = "Kai",
                ConversationKey = "ac1662c2-bc78-4474-8759-014ddca87611",
                ConversationPass = "LnqVZHFa47a7",
                ConversationWorkspace = "314571e1-d570-4127-9682-8cda467d6f42",
                NLUKey = "b7a8afaa-f5f9-4cf7-9978-619e037c661a",
                NLUPass = "JCILzdOV12gD",
                NLUURL = "https://gateway.watsonplatform.net/natural-language-understanding/api"
            };

	        var kaiAgent = client.GetGrain<IAgent>(new Guid("96095149-acb3-4f09-bf65-f62b8b6f9e11"));
            Console.WriteLine("Sending Properties");
            await kaiAgent.SetProperties(properties);
            Console.WriteLine("Sending messsage to the Silo");
            var result = await kaiAgent.SendMessage("create a new site called marketing");
            Console.WriteLine("After result");
            if(result.Success)
            {
                Console.WriteLine(string.Format("result: {0}", JsonConvert.SerializeObject(result, Formatting.Indented)));
            }
            else
            {
                Console.WriteLine("\n\n{0}\n\n", "ERROR: " + result.Output.toString());
            }
        }
    }
}
