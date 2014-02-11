using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI.Game.v1._3
{
    public class GameDto
    {
        private int championId;  //Champion ID associated with game.

        public int ChampionId
        {
            get { return championId; }
            set { championId = value; }
        }
        private long createDate;  //Date that end game data was recorded, specified as epoch milliseconds.

        public long CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        private PlayerDto[] fellowPlayers;  //Other players associated with the game.

        public PlayerDto[] FellowPlayers
        {
            get { return fellowPlayers; }
            set { fellowPlayers = value; }
        }
        private long gameId;  //Game ID.

        public long GameId
        {
            get { return gameId; }
            set { gameId = value; }
        }
        private string gameMode;  //Game mode. (legal values: CLASSIC, ODIN, ARAM, TUTORIAL, ONEFORALL, FIRSTBLOOD)

        public string GameMode
        {
            get { return gameMode; }
            set { gameMode = value; }
        }
        private string gameType;  //Game type. (legal values: CUSTOM_GAME, MATCHED_GAME, TUTORIAL_GAME)

        public string GameType
        {
            get { return gameType; }
            set { gameType = value; }
        }
        private bool invalid;//Invalid flag.

        public bool Invalid
        {
            get { return invalid; }
            set { invalid = value; }
        }
        private int level;  //Level.

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        private int mapId;  //Map ID.

        public int MapId
        {
            get { return mapId; }
            set { mapId = value; }
        }
        private int spell1;  //ID of first summoner spell.

        public int Spell1
        {
            get { return spell1; }
            set { spell1 = value; }
        }
        private int spell2;  //ID of second summoner spell.

        public int Spell2
        {
            get { return spell2; }
            set { spell2 = value; }
        }
        private RawStatsDto stats;  //Statistics associated with the game for this summoner.

        public RawStatsDto Stats
        {
            get { return stats; }
            set { stats = value; }
        }
        private string subType;  //Game sub-type. (legal values: NONE, NORMAL, BOT, RANKED_SOLO_5x5, RANKED_PREMADE_3x3, RANKED_PREMADE_5x5, ODIN_UNRANKED, RANKED_TEAM_3x3, RANKED_TEAM_5x5, NORMAL_3x3, BOT_3x3, ARAM_UNRANKED_5x5, ONEFORALL_5x5, FIRSTBLOOD_1x1, FIRSTBLOOD_2x2)

        public string SubType
        {
            get { return subType; }
            set { subType = value; }
        }
        private int teamId;  //Team ID associated with game.

        public int TeamId
        {
            get { return teamId; }
            set { teamId = value; }
        }
        public GameDto() { }
    }
}
