using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Volume
    {
        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("characters")]
        public List<Character> Characters { get; set; }

        [JsonProperty("concepts")]
        public List<Concept> Concepts { get; set; }

        [JsonProperty("count_of_issues")]
        public int CountOfIssues { get; set; }

        [JsonProperty("date_added")]
        public DateTime Created { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime Modified { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("first_issue")]
        public Issue FirstIssue { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("issues")]
        public List<Issue> Issues { get; set; }

        [JsonProperty("last_issue")]
        public Issue LastIssue { get; set; }

        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objects")]
        public List<Object> Objects { get; set; }

        [JsonProperty("people")]
        public List<Person> People { get; set; }

        [JsonProperty("publisher")]
        public Publisher Publisher { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("start_year")]
        public string StartYear { get; set; }
    }
}