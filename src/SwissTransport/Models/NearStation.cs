using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport.Models
{
    using Newtonsoft.Json;
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class NearStation
    {
        [JsonProperty("label")]
        public string label { get; set; }

        [JsonProperty("dist")]
        public double dist { get; set; }

        [JsonProperty("iconclass")]
        public string iconclass { get; set; }

        [JsonProperty("x")]
        public string x { get; set; }

        [JsonProperty("y")]
        public string y { get; set; }

        [JsonProperty("lon")]
        public double? lon { get; set; }

        [JsonProperty("lat")]
        public double? lat { get; set; }
     
    }


}
