using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI.Game.v1._3
{
    public class RawStatsDto
    {
        private int assists;

        public int Assists
        {
            get { return assists; }
            set { assists = value; }
        }
        private int barracksKilled;

        public int BarracksKilled
        {
            get { return barracksKilled; }
            set { barracksKilled = value; }
        }
        private int championsKilled;

        public int ChampionsKilled
        {
            get { return championsKilled; }
            set { championsKilled = value; }
        }
        private int combatPlayerScore;

        public int CombatPlayerScore
        {
            get { return combatPlayerScore; }
            set { combatPlayerScore = value; }
        }
        private int consumablesPurchased;

        public int ConsumablesPurchased
        {
            get { return consumablesPurchased; }
            set { consumablesPurchased = value; }
        }
        private int damageDealtPlayer;

        public int DamageDealtPlayer
        {
            get { return damageDealtPlayer; }
            set { damageDealtPlayer = value; }
        }
        private int doubleKills;

        public int DoubleKills
        {
            get { return doubleKills; }
            set { doubleKills = value; }
        }
        private int firstBlood;

        public int FirstBlood
        {
            get { return firstBlood; }
            set { firstBlood = value; }
        }
        private int gold;

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        private int goldEarned;

        public int GoldEarned
        {
            get { return goldEarned; }
            set { goldEarned = value; }
        }
        private int goldSpent;

        public int GoldSpent
        {
            get { return goldSpent; }
            set { goldSpent = value; }
        }
        private int item0;

        public int Item0
        {
            get { return item0; }
            set { item0 = value; }
        }
        private int item1;

        public int Item1
        {
            get { return item1; }
            set { item1 = value; }
        }
        private int item2;

        public int Item2
        {
            get { return item2; }
            set { item2 = value; }
        }
        private int item3;

        public int Item3
        {
            get { return item3; }
            set { item3 = value; }
        }
        private int item4;

        public int Item4
        {
            get { return item4; }
            set { item4 = value; }
        }
        private int item5;

        public int Item5
        {
            get { return item5; }
            set { item5 = value; }
        }
        private int item6;

        public int Item6
        {
            get { return item6; }
            set { item6 = value; }
        }
        private int itemsPurchased;

        public int ItemsPurchased
        {
            get { return itemsPurchased; }
            set { itemsPurchased = value; }
        }
        private int killingSprees;

        public int KillingSprees
        {
            get { return killingSprees; }
            set { killingSprees = value; }
        }
        private int largestCriticalStrike;

        public int LargestCriticalStrike
        {
            get { return largestCriticalStrike; }
            set { largestCriticalStrike = value; }
        }
        private int largestKillingSpree;

        public int LargestKillingSpree
        {
            get { return largestKillingSpree; }
            set { largestKillingSpree = value; }
        }
        private int largestMultiKill;

        public int LargestMultiKill
        {
            get { return largestMultiKill; }
            set { largestMultiKill = value; }
        }
        private int legendaryItemsCreated;  //Number of tier 3 items built.

        public int LegendaryItemsCreated
        {
            get { return legendaryItemsCreated; }
            set { legendaryItemsCreated = value; }
        }
        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        private int magicDamageDealtPlayer;

        public int MagicDamageDealtPlayer
        {
            get { return magicDamageDealtPlayer; }
            set { magicDamageDealtPlayer = value; }
        }
        private int magicDamageDealtToChampions;

        public int MagicDamageDealtToChampions
        {
            get { return magicDamageDealtToChampions; }
            set { magicDamageDealtToChampions = value; }
        }
        private int magicDamageTaken;

        public int MagicDamageTaken
        {
            get { return magicDamageTaken; }
            set { magicDamageTaken = value; }
        }
        private int minionsDenied;

        public int MinionsDenied
        {
            get { return minionsDenied; }
            set { minionsDenied = value; }
        }
        private int minionsKilled;

        public int MinionsKilled
        {
            get { return minionsKilled; }
            set { minionsKilled = value; }
        }
        private int neutralMinionsKilled;

        public int NeutralMinionsKilled
        {
            get { return neutralMinionsKilled; }
            set { neutralMinionsKilled = value; }
        }
        private int neutralMinionsKilledEnemyJungle;

        public int NeutralMinionsKilledEnemyJungle
        {
            get { return neutralMinionsKilledEnemyJungle; }
            set { neutralMinionsKilledEnemyJungle = value; }
        }
        private int neutralMinionsKilledYourJungle;

        public int NeutralMinionsKilledYourJungle
        {
            get { return neutralMinionsKilledYourJungle; }
            set { neutralMinionsKilledYourJungle = value; }
        }
        private bool nexusKilled;  //Flag specifying if the summoner got the killing blow on the nexus.

        public bool NexusKilled
        {
            get { return nexusKilled; }
            set { nexusKilled = value; }
        }
        private int nodeCapture;

        public int NodeCapture
        {
            get { return nodeCapture; }
            set { nodeCapture = value; }
        }
        private int nodeCaptureAssist;

        public int NodeCaptureAssist
        {
            get { return nodeCaptureAssist; }
            set { nodeCaptureAssist = value; }
        }
        private int nodeNeutralize;

        public int NodeNeutralize
        {
            get { return nodeNeutralize; }
            set { nodeNeutralize = value; }
        }
        private int nodeNeutralizeAssist;

        public int NodeNeutralizeAssist
        {
            get { return nodeNeutralizeAssist; }
            set { nodeNeutralizeAssist = value; }
        }
        private int numDeaths;

        public int NumDeaths
        {
            get { return numDeaths; }
            set { numDeaths = value; }
        }
        private int numItemsBought;

        public int NumItemsBought
        {
            get { return numItemsBought; }
            set { numItemsBought = value; }
        }
        private int objectivePlayerScore;

        public int ObjectivePlayerScore
        {
            get { return objectivePlayerScore; }
            set { objectivePlayerScore = value; }
        }
        private int pentaKills;

        public int PentaKills
        {
            get { return pentaKills; }
            set { pentaKills = value; }
        }
        private int physicalDamageDealtPlayer;

        public int PhysicalDamageDealtPlayer
        {
            get { return physicalDamageDealtPlayer; }
            set { physicalDamageDealtPlayer = value; }
        }
        private int physicalDamageDealtToChampions;

        public int PhysicalDamageDealtToChampions
        {
            get { return physicalDamageDealtToChampions; }
            set { physicalDamageDealtToChampions = value; }
        }
        private int physicalDamageTaken;

        public int PhysicalDamageTaken
        {
            get { return physicalDamageTaken; }
            set { physicalDamageTaken = value; }
        }
        private int quadraKills;

        public int QuadraKills
        {
            get { return quadraKills; }
            set { quadraKills = value; }
        }
        private int sightWardsBought;

        public int SightWardsBought
        {
            get { return sightWardsBought; }
            set { sightWardsBought = value; }
        }
        private int spell1Cast;  //Number of times first champion spell was cast.

        public int Spell1Cast
        {
            get { return spell1Cast; }
            set { spell1Cast = value; }
        }
        private int spell2Cast;  //Number of times second champion spell was cast.

        public int Spell2Cast
        {
            get { return spell2Cast; }
            set { spell2Cast = value; }
        }
        private int spell3Cast;  //Number of times third champion spell was cast.

        public int Spell3Cast
        {
            get { return spell3Cast; }
            set { spell3Cast = value; }
        }
        private int spell4Cast;  //Number of times fourth champion spell was cast.

        public int Spell4Cast
        {
            get { return spell4Cast; }
            set { spell4Cast = value; }
        }
        private int summonSpell1Cast;

        public int SummonSpell1Cast
        {
            get { return summonSpell1Cast; }
            set { summonSpell1Cast = value; }
        }
        private int summonSpell2Cast;

        public int SummonSpell2Cast
        {
            get { return summonSpell2Cast; }
            set { summonSpell2Cast = value; }
        }
        private int superMonsterKilled;

        public int SuperMonsterKilled
        {
            get { return superMonsterKilled; }
            set { superMonsterKilled = value; }
        }
        private int team;

        public int Team
        {
            get { return team; }
            set { team = value; }
        }
        private int teamObjective;

        public int TeamObjective
        {
            get { return teamObjective; }
            set { teamObjective = value; }
        }
        private int timePlayed;

        public int TimePlayed
        {
            get { return timePlayed; }
            set { timePlayed = value; }
        }
        private int totalDamageDealt;

        public int TotalDamageDealt
        {
            get { return totalDamageDealt; }
            set { totalDamageDealt = value; }
        }
        private int totalDamageDealtToChampions;

        public int TotalDamageDealtToChampions
        {
            get { return totalDamageDealtToChampions; }
            set { totalDamageDealtToChampions = value; }
        }
        private int totalDamageTaken;

        public int TotalDamageTaken
        {
            get { return totalDamageTaken; }
            set { totalDamageTaken = value; }
        }
        private int totalHeal;

        public int TotalHeal
        {
            get { return totalHeal; }
            set { totalHeal = value; }
        }
        private int totalPlayerScore;

        public int TotalPlayerScore
        {
            get { return totalPlayerScore; }
            set { totalPlayerScore = value; }
        }
        private int totalScoreRank;

        public int TotalScoreRank
        {
            get { return totalScoreRank; }
            set { totalScoreRank = value; }
        }
        private int totalTimeCrowdControlDealt;

        public int TotalTimeCrowdControlDealt
        {
            get { return totalTimeCrowdControlDealt; }
            set { totalTimeCrowdControlDealt = value; }
        }
        private int totalUnitsHealed;

        public int TotalUnitsHealed
        {
            get { return totalUnitsHealed; }
            set { totalUnitsHealed = value; }
        }
        private int tripleKills;

        public int TripleKills
        {
            get { return tripleKills; }
            set { tripleKills = value; }
        }
        private int trueDamageDealtPlayer;

        public int TrueDamageDealtPlayer
        {
            get { return trueDamageDealtPlayer; }
            set { trueDamageDealtPlayer = value; }
        }
        private int trueDamageDealtToChampions;

        public int TrueDamageDealtToChampions
        {
            get { return trueDamageDealtToChampions; }
            set { trueDamageDealtToChampions = value; }
        }
        private int trueDamageTaken;

        public int TrueDamageTaken
        {
            get { return trueDamageTaken; }
            set { trueDamageTaken = value; }
        }
        private int turretsKilled;

        public int TurretsKilled
        {
            get { return turretsKilled; }
            set { turretsKilled = value; }
        }
        private int unrealKills;

        public int UnrealKills
        {
            get { return unrealKills; }
            set { unrealKills = value; }
        }
        private int victoryPointTotal;

        public int VictoryPointTotal
        {
            get { return victoryPointTotal; }
            set { victoryPointTotal = value; }
        }
        private int visionWardsBought;

        public int VisionWardsBought
        {
            get { return visionWardsBought; }
            set { visionWardsBought = value; }
        }
        private int wardKilled;

        public int WardKilled
        {
            get { return wardKilled; }
            set { wardKilled = value; }
        }
        private int wardPlaced;

        public int WardPlaced
        {
            get { return wardPlaced; }
            set { wardPlaced = value; }
        }
        private bool win;  //Flag specifying whether or not this game was won.

        public bool Win
        {
            get { return win; }
            set { win = value; }
        }

        public RawStatsDto() { }
    }
}
