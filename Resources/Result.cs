using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace News.Resources
{
    public class Result
    {
        [JsonProperty]
        public string url { get; set; }
        [JsonProperty]
        public string headline { get; set; }
        [JsonProperty]
        public string thumbnail { get; set; }
    }
}