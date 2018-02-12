using System.Collections.Generic;
using Newtonsoft.Json;

namespace classes
{
    /// <summary>
    /// Results of the analysis, organized by feature.
    /// </summary>
    public class CommandMetadata
    {
        /// <summary>
        /// Language used to analyze the text.
        /// </summary>
        /// <value>Language used to analyze the text.</value>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }
        /// <summary>
        /// Text that was used in the analysis.
        /// </summary>
        /// <value>Text that was used in the analysis.</value>
        [JsonProperty("analyzed_text", NullValueHandling = NullValueHandling.Ignore)]
        public string AnalyzedText { get; set; }
        /// <summary>
        /// The general concepts referenced or alluded to in the specified content.
        /// </summary>
        /// <value>The general concepts referenced or alluded to in the specified content.</value>
        [JsonProperty("concepts", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Concepts { get; set; }
        /// <summary>
        /// The important entities in the specified content.
        /// </summary>
        /// <value>The important entities in the specified content.</value>
        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Entities { get; set; }
        /// <summary>
        /// The important keywords in content organized by relevance.
        /// </summary>
        /// <value>The important keywords in content organized by relevance.</value>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Keywords { get; set; }
        /// <summary>
        /// The hierarchical 5-level taxonomy the content is categorized into.
        /// </summary>
        /// <value>The hierarchical 5-level taxonomy the content is categorized into.</value>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Categories { get; set; }
        /// <summary>
        /// The anger, disgust, fear, joy, or sadness conveyed by the content.
        /// </summary>
        /// <value>The anger, disgust, fear, joy, or sadness conveyed by the content.</value>
        [JsonProperty("emotion", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Emotion { get; set; }
        /// <summary>
        /// The subjects of actions and the objects the actions act upon.
        /// </summary>
        /// <value>The subjects of actions and the objects the actions act upon.</value>
        [JsonProperty("semantic_roles", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SemanticRoles { get; set; }
        /// <summary>
        /// The sentiment of the content.
        /// </summary>
        /// <value>The sentiment of the content.</value>
        [JsonProperty("sentiment", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Sentiment { get; set; }
    }

}
