using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class VideoType : NamedEntity
    {
        public new static string SingleEndpoint => "video_type";
        public new static string ListEndpoint => "video_types";
        public new static string EndpointId => "";

        [JsonProperty("api_detail_url")]
        public string ApiDetailUrl { get; set; }

        [JsonProperty("site_detail_url")]
        public string SiteDetailUrl { get; set; }

        [JsonProperty("deck")]
        public string Deck { get; set; }
    }
}