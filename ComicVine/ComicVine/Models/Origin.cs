using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Origin : NamedEntity
    {
        public new static string SingleEndpoint => "origin";
        public new static string ListEndpoint => "origins";
        public new static string EndpointId => "4030";

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("character_set")]
        public string CharacterSet { get; set; }

        [JsonProperty("characters")]
        public List<Character> Characters { get; set; }

        [JsonProperty("profiles")]
        public List<object> Profiles { get; set; } // Unknown data type

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }
    }
}