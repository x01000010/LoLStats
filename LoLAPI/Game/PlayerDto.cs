using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI
{
    class PlayerDto
    {
        private int championId;  //Champion id associated with player.

        public int ChampionId
        {
            get { return championId; }
            set { championId = value; }
        }
        private long summonerId;  //Summoner id associated with player.

        public long SummonerId
        {
            get { return summonerId; }
            set { summonerId = value; }
        }
        private int teamId;  //Team id associated with player.

        public int TeamId
        {
            get { return teamId; }
            set { teamId = value; }
        }
        PlayerDto() { }
    }
}
