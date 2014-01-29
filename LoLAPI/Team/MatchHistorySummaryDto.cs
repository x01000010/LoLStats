using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Team
{
    class MatchHistorySummaryDto
    {
        private int assists;

        public int Assists
        {
            get { return assists; }
            set { assists = value; }
        }
        private int deaths;

        public int Deaths
        {
            get { return deaths; }
            set { deaths = value; }
        }
        private long gameId;

        public long GameId
        {
            get { return gameId; }
            set { gameId = value; }
        }
        private string gameMode;

        public string GameMode
        {
            get { return gameMode; }
            set { gameMode = value; }
        }
        private bool invalid;

        public bool Invalid
        {
            get { return invalid; }
            set { invalid = value; }
        }
        private int kills;

        public int Kills
        {
            get { return kills; }
            set { kills = value; }
        }
        private int mapId;

        public int MapId
        {
            get { return mapId; }
            set { mapId = value; }
        }
        private int opposingTeamKills;

        public int OpposingTeamKills
        {
            get { return opposingTeamKills; }
            set { opposingTeamKills = value; }
        }
        private string opposingTeamName;

        public string OpposingTeamName
        {
            get { return opposingTeamName; }
            set { opposingTeamName = value; }
        }
        private bool win;

        public bool Win
        {
            get { return win; }
            set { win = value; }
        }

        MatchHistorySummaryDto() { }
    }
}
