namespace SwissTransport.Models
{
    using Newtonsoft.Json;

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class NearStation
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("dist")]
        public double Dist { get; set; }

        [JsonProperty("iconclass")]
        public string Iconclass { get; set; }

        [JsonProperty("x")]
        public string X { get; set; }

        [JsonProperty("y")]
        public string Y { get; set; }

        [JsonProperty("lon")]
        public double? Lon { get; set; }

        [JsonProperty("lat")]
        public double? Lat { get; set; }
    }
}
