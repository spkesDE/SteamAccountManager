using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAccountManager
{
    public class Game
    {
        public bool hasCover { get; set; } = false;

        [JsonProperty("appid")] 
        public int appid { get; set; }

        [JsonProperty("name")]
        public String name { get; set; }

        [JsonProperty("playtime_forever")]
        public int playtime_forever { get; set; }

        [JsonProperty("img_icon_url")]
        public String img_icon_url { get; set; }

        [JsonProperty("img_logo_url")]
        public String img_logo_url { get; set; }

        [JsonProperty("has_community_visible_stats")]
        public Boolean has_community_visible_stats { get; set; }

        [JsonProperty("playtime_windows_forever")]
        public int playtime_windows_forever { get; set; }

        [JsonProperty("playtime_mac_forever")]
        public int playtime_mac_forever { get; set; }

        [JsonProperty("playtime_linux_forever")]
        public int playtime_linux_forever { get; set; }
        public Boolean banned { get; set; } = false;
        public String accountName { get; set; }
        public Boolean usesPlaceholder { get; set; } = false;

        [JsonIgnore]
        public Panel mainPanel { get; set; }
        [JsonIgnore]
        public Label gameName { get; set; }
        [JsonIgnore]
        public Label accountLabel { get; set; }
        [JsonIgnore]
        public Label ripLabel { get; set; }

    }
}
