using System;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Promo : NamedEntity
    {
        public new static string SingleEndpoint => "promo";
        public new static string ListEndpoint => "promos";
        public new static string EndpointId => "1700";

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("date_added")]
        public DateTime? Created { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }
}