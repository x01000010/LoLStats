using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLStats
{
    public class AHGL_Player
    {
        private string name;
        private string inGameName;
        private string teamName;
        private string webpage;        

        public AHGL_Player(string name, string inGameName, string teamName, string webpage)
        {
            this.name = name;
            this.inGameName = inGameName;
            this.teamName = teamName;
            this.webpage = webpage;
        }

        public AHGL_Player(string inGameName, string teamName) : this(string.Empty, inGameName, teamName, string.Empty) { }

        public AHGL_Player(string inGameName, string teamName, string webpage) : this(string.Empty, inGameName, teamName, webpage) { }
    }
}
