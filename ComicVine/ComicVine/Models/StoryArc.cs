using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class StoryArc : NamedEntity
    {
        public new static string SingleEndpoint => "story_arc";
        public new static string ListEndpoint => "story_arcs";
        public new static string EndpointId => "4045";

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

        [JsonProperty("episodes")]
        public List<Episode> Episodes { get; set; }

        [JsonProperty("first_appeared_in_episode")]
        public Episode FirstAppearedInEpisode { get; set; }

        [JsonProperty("first_appeared_in_issue")]
        public Issue FirstAppearedInIssue { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("issues")]
        public List<Issue> Issues { get; set; }

        [JsonProperty("movies")]
        public List<Movie> Movies { get; set; }

        [JsonProperty("publisher")]
        public Publisher Publisher { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }
    }
}