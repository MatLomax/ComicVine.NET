using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Movie
    {
        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("box_office_revenue")]
        public string BoxOfficeRevenue { get; set; }

        [JsonProperty("budget")]
        public string Budget { get; set; }

        [JsonProperty("characters")]
        public List<Character> Characters { get; set; }

        [JsonProperty("concepts")]
        public List<Concept> Concepts { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime DateLastUpdated { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distributor")]
        public string Distributor { get; set; }

        [JsonProperty("has_staff_review")]
        public string HasStaffReview { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("locations")]
        public List<Location> Locations { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objects")]
        public List<Object> Objects { get; set; }

        [JsonProperty("producers")]
        public List<Person> Producers { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("runtime")]
        public string Runtime { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("studios")]
        public List<Publisher> Studios { get; set; }

        [JsonProperty("teams")]
        public List<Team> Teams { get; set; }

        [JsonProperty("total_revenue")]
        public string TotalRevenue { get; set; }

        [JsonProperty("writers")]
        public List<Person> Writers { get; set; }
    }
}