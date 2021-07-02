using Newtonsoft.Json;

namespace Countries
{
    class Country 
    {
        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }
    }
}
