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

        public int AverageChampionsKilled
        {
            get { return averageChampionsKilled; }
            set { averageChampionsKilled = value; }
        }
        private int averageCombatPlayerScore;  //Dominion only.

        public int AverageCombatPlayerScore
        {
            get { return averageCombatPlayerScore; }
            set { averageCombatPlayerScore = value; }
        }
        private int averageNodeCapture;  //Dominion only.

        public int AverageNodeCapture
        {
            get { return averageNodeCapture; }
            set { averageNodeCapture = value; }
        }
        private int averageNodeCaptureAssist;  //Dominion only.

        public int AverageNodeCaptureAssist
        {
            get { return averageNodeCaptureAssist; }
            set { averageNodeCaptureAssist = value; }
        }
        private int averageNodeNeutralize;  //Dominion only.

        public int AverageNodeNeutralize
        {
            get { return averageNodeNeutralize; }
            set { averageNodeNeutralize = value; }
        }
        private int averageNodeNeutralizeAssist;  //Dominion only.

        public int AverageNodeNeutralizeAssist
        {
            get { return averageNodeNeutralizeAssist; }
            set { averageNodeNeutralizeAssist = value; }
        }
        private int averageNumDeaths;  //Dominion only.

        public int AverageNumDeaths
        {
            get { return averageNumDeaths; }
            set { averageNumDeaths = value; }
        }
        private int averageObjectivePlayerScore;  //Dominion only.

        public int AverageObjectivePlayerScore
        {
            get { return averageObjectivePlayerScore; }
            set { averageObjectivePlayerScore = value; }
        }
        private int averageTeamObjective;  //Dominion only.

        public int AverageTeamObjective
        {
            get { return averageTeamObjective; }
            set { averageTeamObjective = value; }
        }
        private int averageTotalPlayerScore;  //Dominion only.

        public int AverageTotalPlayerScore
        {
            get { return averageTotalPlayerScore; }
            set { averageTotalPlayerScore = value; }
        }
        private int botGamesPlayed;

        public int BotGamesPlayed
        {
            get { return botGamesPlayed; }
            set { botGamesPlayed = value; }
        }
        private int killingSpree;

        public int KillingSpree
        {
            get { return killingSpree; }
            set { killingSpree = value; }
        }
        private int maxAssists;  //Dominion only.

        public int MaxAssists
        {
            get { return maxAssists; }
            set { maxAssists = value; }
        }
        private int maxChampionsKilled;

        public int MaxChampionsKilled
        {
            get { return maxChampionsKilled; }
            set { maxChampionsKilled = value; }
        }
        private int maxCombatPlayerScore;  //Dominion only.

        public int MaxCombatPlayerScore
        {
            get { return maxCombatPlayerScore; }
            set { maxCombatPlayerScore = value; }
        }
        private int maxLargestCriticalStrike;

        public int MaxLargestCriticalStrike
        {
            get { return maxLargestCriticalStrike; }
            set { maxLargestCriticalStrike = value; }
        }
        private int maxLargestKillingSpree;

        public int MaxLargestKillingSpree
        {
            get { return maxLargestKillingSpree; }
            set { maxLargestKillingSpree = value; }
        }
        private int maxNodeCapture;  //Dominion only.

        public int MaxNodeCapture
        {
            get { return maxNodeCapture; }
            set { maxNodeCapture = value; }
        }
        private int maxNodeCaptureAssist;  //Dominion only.

        public int MaxNodeCaptureAssist
        {
            get { return maxNodeCaptureAssist; }
            set { maxNodeCaptureAssist = value; }
        }
        private int maxNodeNeutralize;  //Dominion only.

        public int MaxNodeNeutralize
        {
            get { return maxNodeNeutralize; }
            set { maxNodeNeutralize = value; }
        }
        private int maxNodeNeutralizeAssist;  //Dominion only.

        public int MaxNodeNeutralizeAssist
        {
            get { return maxNodeNeutralizeAssist; }
            set { maxNodeNeutralizeAssist = value; }
        }
        private int maxNumDeaths;  //Only returned for ranked statistics.

        public int MaxNumDeaths
        {
            get { return maxNumDeaths; }
            set { maxNumDeaths = value; }
        }
        private int maxObjectivePlayerScore;  //Dominion only.

        public int MaxObjectivePlayerScore
        {
            get { return maxObjectivePlayerScore; }
            set { maxObjectivePlayerScore = value; }
        }
        private int maxTeamObjective;  //Dominion only.

        public int MaxTeamObjective
        {
            get { return maxTeamObjective; }
            set { maxTeamObjective = value; }
        }
        private int maxTimePlayed;

        public int MaxTimePlayed
        {
            get { return maxTimePlayed; }
            set { maxTimePlayed = value; }
        }
        private int maxTimeSpentLiving;

        public int MaxTimeSpentLiving
        {
            get { return maxTimeSpentLiving; }
            set { maxTimeSpentLiving = value; }
        }
        private int maxTotalPlayerScore; //Dominion only.

        public int MaxTotalPlayerScore
        {
            get { return maxTotalPlayerScore; }
            set { maxTotalPlayerScore = value; }
        }
        private int mostChampionKillsPerSession;

        public int MostChampionKillsPerSession
        {
            get { return mostChampionKillsPerSession; }
            set { mostChampionKillsPerSession = value; }
        }
        private int mostSpellsCast;

        public int MostSpellsCast
        {
            get { return mostSpellsCast; }
            set { mostSpellsCast = value; }
        }
        private int normalGamesPlayed;

        public int NormalGamesPlayed
        {
            get { return normalGamesPlayed; }
            set { normalGamesPlayed = value; }
        }
        private int rankedPremadeGamesPlayed;

        public int RankedPremadeGamesPlayed
        {
            get { return rankedPremadeGamesPlayed; }
            set { rankedPremadeGamesPlayed = value; }
        }
        private int rankedSoloGamesPlayed;

        public int RankedSoloGamesPlayed
        {
            get { return rankedSoloGamesPlayed; }
            set { rankedSoloGamesPlayed = value; }
        }
        private int totalAssists;

        public int TotalAssists
        {
            get { return totalAssists; }
            set { totalAssists = value; }
        }
        private int totalChampionKills;

        public int TotalChampionKills
        {
            get { return totalChampionKills; }
            set { totalChampionKills = value; }
        }
        private int totalDamageDealt;

        public int TotalDamageDealt
        {
            get { return totalDamageDealt; }
            set { totalDamageDealt = value; }
        }
        private int totalDamageTaken;

        public int TotalDamageTaken
        {
            get { return totalDamageTaken; }
            set { totalDamageTaken = value; }
        }
        private int totalDeathsPerSession;  //Only returned for ranked statistics.

        public int TotalDeathsPerSession
        {
            get { return totalDeathsPerSession; }
            set { totalDeathsPerSession = value; }
        }
        private int totalDoubleKills;

        public int TotalDoubleKills
        {
            get { return totalDoubleKills; }
            set { totalDoubleKills = value; }
        }
        private int totalFirstBlood;

        public int TotalFirstBlood
        {
            get { return totalFirstBlood; }
            set { totalFirstBlood = value; }
        }
        private int totalGoldEarned;

        public int TotalGoldEarned
        {
            get { return totalGoldEarned; }
            set { totalGoldEarned = value; }
        }
        private int totalHeal;

        public int TotalHeal
        {
            get { return totalHeal; }
            set { totalHeal = value; }
        }
        private int totalMagicDamageDealt;

        public int TotalMagicDamageDealt
        {
            get { return totalMagicDamageDealt; }
            set { totalMagicDamageDealt = value; }
        }
        private int totalMinionKills;

        public int TotalMinionKills
        {
            get { return totalMinionKills; }
            set { totalMinionKills = value; }
        }
        private int totalNeutralMinionsKilled;

        public int TotalNeutralMinionsKilled
        {
            get { return totalNeutralMinionsKilled; }
            set { totalNeutralMinionsKilled = value; }
        }
        private int totalNodeCapture;  //Dominion only.

        public int TotalNodeCapture
        {
            get { return totalNodeCapture; }
            set { totalNodeCapture = value; }
        }
        private int totalNodeNeutralize;  //Dominion only.

        public int TotalNodeNeutralize
        {
            get { return totalNodeNeutralize; }
            set { totalNodeNeutralize = value; }
        }
        private int totalPentaKills;

        public int TotalPentaKills
        {
            get { return totalPentaKills; }
            set { totalPentaKills = value; }
        }
        private int totalPhysicalDamageDealt;

        public int TotalPhysicalDamageDealt
        {
            get { return totalPhysicalDamageDealt; }
            set { totalPhysicalDamageDealt = value; }
        }
        private int totalQuadraKills;

        public int TotalQuadraKills
        {
            get { return totalQuadraKills; }
            set { totalQuadraKills = value; }
        }
        private int totalSessionsLost;

        public int TotalSessionsLost
        {
            get { return totalSessionsLost; }
            set { totalSessionsLost = value; }
        }
        private int totalSessionsPlayed;

        public int TotalSessionsPlayed
        {
            get { return totalSessionsPlayed; }
            set { totalSessionsPlayed = value; }
        }
        private int totalSessionsWon;

        public int TotalSessionsWon
        {
            get { return totalSessionsWon; }
            set { totalSessionsWon = value; }
        }
        private int totalTripleKills;

        public int TotalTripleKills
        {
            get { return totalTripleKills; }
            set { totalTripleKills = value; }
        }
        private int totalTurretsKilled;

        public int TotalTurretsKilled
        {
            get { return totalTurretsKilled; }
            set { totalTurretsKilled = value; }
        }
        private int totalUnrealKills;

        public int TotalUnrealKills1
        {
            get { return totalUnrealKills; }
            set { totalUnrealKills = value; }
        }

        public int TotalUnrealKills
        {
            get { return totalUnrealKills; }
            set { totalUnrealKills = value; }
        }

        AggregatedStatsDto() { }
    }
}
