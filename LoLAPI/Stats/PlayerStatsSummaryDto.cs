using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Stats
{
    class PlayerStatsSummaryDto
    {
        private AggregatedStatsDto aggregatedStats;  //Aggregated stats.

        internal AggregatedStatsDto AggregatedStats
        {
            get { return aggregatedStats; }
            set { aggregatedStats = value; }
        }
        private int losses;  //Number of losses for this queue type. Returned for ranked queue types only.

        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }
        private long modifyDate;  //Date stats were last modified specified as epoch milliseconds.

        public long ModifyDate
        {
            get { return modifyDate; }
            set { modifyDate = value; }
        }
        private string playerStatSummaryType;  //Player stats summary type. (legal values: AramUnranked5x5, CoopVsAI, CoopVsAI3x3, OdinUnranked, RankedPremade3x3, RankedPremade5x5, RankedSolo5x5, RankedTeam3x3, RankedTeam5x5, Unranked, Unranked3x3, OneForAll5x5, FirstBlood1x1, FirstBlood2x2)

        public string PlayerStatSummaryType
        {
            get { return playerStatSummaryType; }
            set { playerStatSummaryType = value; }
        }
        private int wins;  //Number of wins for this queue type.

        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        PlayerStatsSummaryDto() { }
    }
}
