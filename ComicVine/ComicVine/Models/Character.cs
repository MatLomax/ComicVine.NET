using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Character
    {
        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("birth")]
        public DateTime Birth { get; set; }

        [JsonProperty("character_enemies")]
        public List<Character> CharacterEnemies { get; set; }

        [JsonProperty("character_friends")]
        public List<Character> CharacterFriends { get; set; }

        [JsonProperty("count_of_issue_appearances")]
        public int CountOfIssueAppearances { get; set; }

        [JsonProperty("creators")]
        public List<Person> Creators { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime DateLastUpdated { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("first_appeared_in_issue")]
        public Issue FirstAppearedInIssue { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("issue_credits")]
        public List<Issue> IssueCredits { get; set; }

        [JsonProperty("issues_died_in")]
        public List<Issue> IssuesDiedIn { get; set; }

        [JsonProperty("movies")]
        public List<Movie> Movies { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin")]
        public Origin Origin { get; set; }

        [JsonProperty("powers")]
        public List<Power> Powers { get; set; }

        [JsonProperty("publisher")]
        public Publisher Publisher { get; set; }

        [JsonProperty("real_name")]
        public string RealName { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [JsonProperty("team_enemies")]
        public List<Team> TeamEnemies { get; set; }

        [JsonProperty("team_friends")]
        public List<Team> TeamFriends { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }

        [JsonProperty("volume_credits")]
        public List<Volume> VolumeCredits { get; set; }
    }
}