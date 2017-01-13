using Newtonsoft.Json;

namespace ComicVine.Models
{
    public abstract class Entity
    {
        public static string SingleEndpoint => "";
        public static string ListEndpoint => "";
        public static string EndpointId => "";

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
