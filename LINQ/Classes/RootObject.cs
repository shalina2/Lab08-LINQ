using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    public class RootObject
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("features")]
        public List<Feature> features { get; set; }
    }
}
