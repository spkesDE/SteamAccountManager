using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamAccountManager {
    public class Config {
        public string useSteamGridDBKey { get; set; }
        public Boolean useSteamGridDB { get; set; } = false;
        public String steamPath { get; set; }
        public String placeHolderCover { get; set; }
        public Boolean minimize { get; set; } = true;
        public Boolean onlyLogin { get; set; } = true;
        public Boolean toTrayOnClose { get; set; } = false;
        public String bannedText { get; set; } = "R.I.P";
        public int xLocation { get; set; } = 5;
        public int yLocation { get; set; } = 5;
    }
}
