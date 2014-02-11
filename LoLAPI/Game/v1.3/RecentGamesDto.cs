using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI.Game.v1._3
{
    public class RecentGamesDto
    {

        private HashSet<GameDto> games;

        public HashSet<GameDto> Games
        {
            get { return games; }
            set { games = value; }
        }       


        private long summonerId;

        public long SummonerId
        {
            get { return summonerId; }
            set { summonerId = value; }
        }

        
        public RecentGamesDto(
            ) { }
    }
}
