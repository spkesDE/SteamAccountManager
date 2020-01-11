using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamAccountManager
{
    public class Account
    {
        [JsonIgnore]
        internal ToolStripMenuItem contextMenuItem;

        public Account(string name, string pw, string id, string apikey)
        {
            this.accountName = name;
            this.accountPass = pw;
            this.steamId = id;
            this.key = apikey;
        }

        [JsonProperty("accountName")]
        public String accountName { get; set; }

        [JsonProperty("accountPass")]
        public String accountPass { get; set; }

        [JsonProperty("key")]
        public String key { get; set; }

        [JsonProperty("steamid")]
        public String steamId { get; set; }

        [JsonIgnore]
        public List<Game> games { get; set; } = new List<Game>();

        public Game getGame(int appid) {
            return null;
        }

        public void addGame(Game g) {
            games.Add(g);
        }
    }
}
