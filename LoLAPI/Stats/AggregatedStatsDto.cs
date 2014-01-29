using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Stats
{
    class AggregatedStatsDto
    {
        private int averageAssists;  //Dominion only.

        public int AverageAssists
        {
            get { return averageAssists; }
            set { averageAssists = value; }
        }
        private int averageChampionsKilled;  //Dominion only.
        private int averageCombatPlayerScore;  //Dominion only.
        private int averageNodeCapture;  //Dominion only.
        private int averageNodeCaptureAssist;  //Dominion only.
        private int averageNodeNeutralize;  //Dominion only.
        private int averageNodeNeutralizeAssist;  //Dominion only.
        private int averageNumDeaths;  //Dominion only.
        private int averageObjectivePlayerScore;  //Dominion only.
        private int averageTeamObjective;  //Dominion only.
        private int averageTotalPlayerScore;  //Dominion only.
        private int botGamesPlayed;
        private int killingSpree;
        private int maxAssists;  //Dominion only.
        private int maxChampionsKilled;
        private int maxCombatPlayerScore;  //Dominion only.
        private int maxLargestCriticalStrike;
        private int maxLargestKillingSpree;
        private int maxNodeCapture;  //Dominion only.
        private int maxNodeCaptureAssist;  //Dominion only.
        private int maxNodeNeutralize;  //Dominion only.
        private int maxNodeNeutralizeAssist;  //Dominion only.
        private int maxNumDeaths;  //Only returned for ranked statistics.
        private int maxObjectivePlayerScore;  //Dominion only.
        private int maxTeamObjective;  //Dominion only.
        private int maxTimePlayed;
        private int maxTimeSpentLiving;
        private int maxTotalPlayerScore; //Dominion only.
        private int mostChampionKillsPerSession;
        private int mostSpellsCast;
        private int normalGamesPlayed;
        private int rankedPremadeGamesPlayed;
        private int rankedSoloGamesPlayed;
        private int totalAssists;
        private int totalChampionKills;
        private int totalDamageDealt;
        private int totalDamageTaken;
        private int totalDeathsPerSession;  //Only returned for ranked statistics.
        private int totalDoubleKills;
        private int totalFirstBlood;
        private int totalGoldEarned;
        private int totalHeal;
        private int totalMagicDamageDealt;
        private int totalMinionKills;
        private int totalNeutralMinionsKilled;
        private int totalNodeCapture;  //Dominion only.
        private int totalNodeNeutralize;  //Dominion only.
        private int totalPentaKills;
        private int totalPhysicalDamageDealt;
        private int totalQuadraKills;
        private int totalSessionsLost;
        private int totalSessionsPlayed;
        private int totalSessionsWon;
        private int totalTripleKills;
        private int totalTurretsKilled;
        private int totalUnrealKills;

        AggregatedStatsDto() { }
    }
}
