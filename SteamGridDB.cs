using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAccountManager
{
    public class SteamGridDB
    {

        [JsonProperty("id")] 
        public int id { get; set; }

        [JsonProperty("score")]
        public int score { get; set; }

        [JsonProperty("style")]
        public String style { get; set; }

        [JsonProperty("url")]
        public String url { get; set; }

        [JsonProperty("thumb")]
        public String thumb { get; set; }
    }
}
