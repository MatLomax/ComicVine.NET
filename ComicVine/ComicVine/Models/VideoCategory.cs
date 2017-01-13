using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class VideoCategory : NamedEntity
    {
        public new static string SingleEndpoint => "video_category";
        public new static string ListEndpoint => "video_categories";
        public new static string EndpointId => "";

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }
    }
}