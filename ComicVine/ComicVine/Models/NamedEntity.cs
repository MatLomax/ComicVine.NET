using Newtonsoft.Json;

namespace ComicVine.Models
{
    public abstract class NamedEntity : Entity
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
