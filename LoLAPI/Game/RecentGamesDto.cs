using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI
{
    class RecentGamesDto
    {
        private HashSet<GameDto> games;

        private HashSet<GameDto> Games
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
        RecentGamesDto() { }
    }
}
