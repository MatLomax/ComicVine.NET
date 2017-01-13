using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Type : Entity
    {
        public new static string SingleEndpoint => "";
        public new static string ListEndpoint => "types";
        public new static string EndpointId => "";

        [JsonProperty("detail_resource_name")]
        public string DetailResourceName { get; set; }

        [JsonProperty("list_resource_name")]
        public string ListResourceName { get; set; }
    }
}