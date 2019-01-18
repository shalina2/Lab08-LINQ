using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
   public class Geometry
    {

        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("type")]
        public List<double> coordinates { get; set; }
        
    }
}
