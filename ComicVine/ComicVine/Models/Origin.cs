using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Origin
    {
        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("character_set")]
        public string CharacterSet { get; set; }

        [JsonProperty("characters")]
        public List<Character> Characters { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profiles")]
        public List<object> Profiles { get; set; } // Unknown data type

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }
    }
}