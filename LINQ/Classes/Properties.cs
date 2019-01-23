using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    public class Properties
    {
        [JsonProperty("zip")]
        public string zip { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("state")]
        public string state { get; set; }
        [JsonProperty("address")]
        public string address { get; set; }
        [JsonProperty("borough")]
        public string borough { get; set; }
        [JsonProperty("neighborhood")]
        public string neighborhood { get; set; }
        [JsonProperty("county")]
        public string county { get; set; }
    }
}
