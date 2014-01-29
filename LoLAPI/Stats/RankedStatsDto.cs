using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Stats
{
    class RankedStatsDto
    {
        private ChampionStatsDto[] champions;  //List of aggregated stats summarized by champion.

        internal ChampionStatsDto[] Champions
        {
            get { return champions; }
            set { champions = value; }
        }
        private long modifyDate;  //Date stats were last modified specified as epoch milliseconds.

        public long ModifyDate
        {
            get { return modifyDate; }
            set { modifyDate = value; }
        }
        private long summonerId;  //Summoner ID.

        public long SummonerId
        {
            get { return summonerId; }
            set { summonerId = value; }
        }

        RankedStatsDto() { }
    }
}
