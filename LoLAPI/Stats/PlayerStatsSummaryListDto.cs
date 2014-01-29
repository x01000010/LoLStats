using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Stats
{
    class PlayerStatsSummaryListDto
    {
        private PlayerStatsSummaryDto[] playerStatSummaries;  //List of player stats summaries associated with the summoner.

        internal PlayerStatsSummaryDto[] PlayerStatSummaries
        {
            get { return playerStatSummaries; }
            set { playerStatSummaries = value; }
        }
        private long summonerId;  //Summoner ID.

        public long SummonerId
        {
            get { return summonerId; }
            set { summonerId = value; }
        }

        PlayerStatsSummaryListDto() { }
    }
}
