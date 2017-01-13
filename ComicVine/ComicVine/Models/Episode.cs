using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Episode : NamedEntity
    {
        public new static string SingleEndpoint => "episode";
        public new static string ListEndpoint => "episodes";
        public new static string EndpointId => "4070";

        [JsonProperty("air_date")]
        public DateTime? AirDate { get; set; }

        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("character_credits")]
        public List<Character> CharacterCredits { get; set; }

        [JsonProperty("character_died_in")]
        public List<Character> CharacterDiedIn { get; set; }

        [JsonProperty("concept_credits")]
        public List<Concept> ConceptCredits { get; set; }

        [JsonProperty("date_added")]
        public DateTime? Created { get; set; }

        [JsonProperty("date_last_updated")]
        public DateTime? Modified { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("episode_number")]
        public string EpisodeNumber { get; set; }

        [JsonProperty("first_appearance_characters")]
        public List<Character> FirstAppearanceCharacters { get; set; }

        [JsonProperty("first_appearance_concepts")]
        public List<Concept> FirstAppearanceConcepts { get; set; }

        [JsonProperty("first_appearance_locations")]
        public List<Location> FirstAppearanceLocations { get; set; }

        [JsonProperty("first_appearance_objects")]
        public List<Object> FirstAppearanceObjects { get; set; }

        [JsonProperty("first_appearance_storyarcs")]
        public List<StoryArc> FirstAppearanceStoryarcs { get; set; }

        [JsonProperty("first_appearance_teams")]
        public List<Team> FirstAppearanceTeams { get; set; }

        [JsonProperty("has_staff_review")]
        public bool HasStaffReview { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("location_credits")]
        public List<Location> LocationCredits { get; set; }

        [JsonProperty("object_credits")]
        public List<Object> ObjectCredits { get; set; }

        [JsonProperty("series")]
        public Series Series { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("story_arc_credits")]
        public List<StoryArc> StoryArcCredits { get; set; }

        [JsonProperty("team_credits")]
        public List<Team> TeamCredits { get; set; }
    }
}