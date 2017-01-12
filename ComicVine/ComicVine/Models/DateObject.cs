using System;
using Newtonsoft.Json;

namespace ComicVine.Models
{
    public class DateObject
    {
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_type")]
        public int TimezoneType { get; set; }
    }
}