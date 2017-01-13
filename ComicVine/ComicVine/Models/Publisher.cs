using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Publisher : NamedEntity
    {
        public new static string SingleEndpoint => "publisher";
        public new static string ListEndpoint => "publishers";
        public new static string EndpointId => "4010";

        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("characters")]
        public List<Character> Characters { get; set; }

        [JsonProperty("date_added")]
        public DateTime? Created { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime? Modified { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("location_address")]
        public string LocationAddress { get; set; }

        [JsonProperty("location_city")]
        public string LocationCity { get; set; }

        [JsonProperty("location_state")]
        public string LocationState { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("story_arcs")]
        public List<StoryArc> StoryArcs { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }

        [JsonProperty("volumes")]
        public List<Volume> Volumes { get; set; }
    }
}