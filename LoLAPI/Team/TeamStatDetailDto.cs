using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Team
{
    class TeamStatDetailDto
    {
        private int averageGamesPlayed;

        public int AverageGamesPlayed
        {
            get { return averageGamesPlayed; }
            set { averageGamesPlayed = value; }
        }
        private string fullId;

        public string FullId
        {
            get { return fullId; }
            set { fullId = value; }
        }
        private int losses;

        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }
        private string teamStatType;

        public string TeamStatType
        {
            get { return teamStatType; }
            set { teamStatType = value; }
        }
        private int wins;

        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        TeamStatDetailDto() { }
    }
}
