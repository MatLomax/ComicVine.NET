using System;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Concept : NamedEntity
    {
        public new static string SingleEndpoint => "concept";
        public new static string ListEndpoint => "concepts";
        public new static string EndpointId => "4015";

        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("count_of_isssue_appearances")]
        public int CountOfIssueAppearances { get; set; }

        [JsonProperty("date_added")]
        public DateTime? Created { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime? Modified { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("first_appeared_in_issue")]
        public Issue FirstAppearedInIssue { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("start_year")]
        public string StartYear { get; set; }
    }
}