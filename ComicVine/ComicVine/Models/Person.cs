using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Person
    {
        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("birth")]
        public DateTime Birth { get; set; }

        [JsonProperty("count_of_isssue_appearances")]
        public int CountOfIssueAppearances { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("created_characters")]
        public List<Character> CreatedCharacters { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime DateLastUpdated { get; set; }

        [JsonProperty("death")]
        public DateTime Death { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; } // TODO: Create gender enum

        [JsonProperty("hometown")]
        public string Hometown { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("issues")]
        public List<Issue> Issues { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [JsonProperty("volume_credits")]
        public List<Volume> VolumeCredits { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }
}