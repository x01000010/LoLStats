using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI
{
    class LeagueItemDto
    {
        private bool isFreshBlood;

        public bool IsFreshBlood
        {
            get { return isFreshBlood; }
            set { isFreshBlood = value; }
        }
        private bool isHotStreak;

        public bool IsHotStreak
        {
            get { return isHotStreak; }
            set { isHotStreak = value; }
        }
        private bool isInactive;

        public bool IsInactive
        {
            get { return isInactive; }
            set { isInactive = value; }
        }
        private bool isVeteran;

        public bool IsVeteran
        {
            get { return isVeteran; }
            set { isVeteran = value; }
        }
        private long lastPlayed;

        public long LastPlayed
        {
            get { return lastPlayed; }
            set { lastPlayed = value; }
        }
        private string leagueName;

        public string LeagueName
        {
            get { return leagueName; }
            set { leagueName = value; }
        }
        private int leaguePoints;

        public int LeaguePoints
        {
            get { return leaguePoints; }
            set { leaguePoints = value; }
        }
        private MiniSeriesDto miniSeries;

        public MiniSeriesDto MiniSeries
        {
            get { return miniSeries; }
            set { miniSeries = value; }
        }
        private string playerOrTeamId;

        public string PlayerOrTeamId
        {
            get { return playerOrTeamId; }
            set { playerOrTeamId = value; }
        }
        private string playerOrTeamName;

        public string PlayerOrTeamName
        {
            get { return playerOrTeamName; }
            set { playerOrTeamName = value; }
        }
        private string queueType;

        public string QueueType
        {
            get { return queueType; }
            set { queueType = value; }
        }
        private string rank;

        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        private string tier;

        public string Tier
        {
            get { return tier; }
            set { tier = value; }
        }
        private int wins;

        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        LeagueItemDto() { }
    }
}
