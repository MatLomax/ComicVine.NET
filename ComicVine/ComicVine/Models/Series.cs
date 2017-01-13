using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Series : NamedEntity
    {
        public new static string SingleEndpoint => "series";
        public new static string ListEndpoint => "series_list";
        public new static string EndpointId => "4075";

        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("characters")]
        public List<Character> Characters { get; set; }

        [JsonProperty("count_of_episodes")]
        public int CountOfEpisodes { get; set; }

        [JsonProperty("date_added")]
        public DateTime? Created { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime? Modified { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("episodes")]
        public List<Episode> Episodes { get; set; }

        [JsonProperty("first_episode")]
        public Episode FirstEpisode { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("last_episode")]
        public Episode LastEpisode { get; set; }
        
        [JsonProperty("publisher")]
        public Publisher Publisher { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("start_year")]
        public string StartYear { get; set; }
    }
}