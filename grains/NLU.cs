using System;
using System.Threading.Tasks;
using interfaces;
using Orleans;
using classes;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;

namespace Name
{
    class NLUGrain: Grain, INLU
    {
        // Natural Language Understanding Service Properties. Eg. Credentials
        private NLUProperties NLUSProps;
        NaturalLanguageUnderstandingService KaiNLUService;
        public override async Task OnActivateAsync()
        {
            if(NLUSProps != null && !String.IsNullOrEmpty(NLUSProps.NLUPass) && !String.IsNullOrEmpty(NLUSProps.URL))
            {
                string NLUSKey;
                this.GetPrimaryKey(out NLUSKey);
                KaiNLUService = new NaturalLanguageUnderstandingService(NLUSKey, NLUSProps.NLUPass, NaturalLanguageUnderstandingService.NATURAL_LANGUAGE_UNDERSTANDING_VERSION_DATE_2017_02_27);
                KaiNLUService.Endpoint = NLUSProps.URL;
            }
            await OnActivateAsync();
        }
        public async Task SetProperties(NLUProperties properties)
        {
            NLUSProps = properties;
            await OnActivateAsync();
        }
        public async Task<NLUProperties> GetProperties()
        {
            return NLUSProps;
        }
        public async Task<CommandMetadata> GetCommandMetadata(string message)
        {
            try
            {
                CommandMetadata metadata = new CommandMetadata();
                if(KaiNLUService != null)
                {
                    Parameters parameters = new Parameters()
                    {
                        Text = message,
                        Features = new Features()
                        {
                            Keywords = new KeywordsOptions()
                            {
                                Limit = 8,
                                Sentiment = true,
                                Emotion = true
                            }
                        }
                    };
                    AnalysisResults result = KaiNLUService.Analyze(parameters);
                    metadata.AnalyzedText = result.AnalyzedText;
                    metadata.Keywords = result.Keywords;
                    metadata.Sentiment = result.Sentiment;
                    //metadata.Emotion = result.Emotion;
                    //metadata.SemanticRoles = result.SemanticRoles;
                    return metadata;
                }
                else
                {
                    throw new Exception("My NLU Service hasn't been configured");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}