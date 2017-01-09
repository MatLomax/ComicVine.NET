using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class Type
    {
        [JsonProperty("detail_resource_name")]
        public string DetailResourceName { get; set; }

        [JsonProperty("list_resource_name")]
        public string ListResourceName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}