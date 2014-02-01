using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI
{
    public class ChampionDto
    {
        private bool active;  //Indicates if the champion is active.

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        private int attackRank;  //Champion attack rank.

        public int AttackRank
        {
            get { return attackRank; }
            set { attackRank = value; }
        }
        private bool botEnabled;  //Bot enabled flag (for custom games).

        public bool BotEnabled
        {
            get { return botEnabled; }
            set { botEnabled = value; }
        }
        private bool botMmEnabled;  //Bot Match Made enabled flag (for Co-op vs. AI games).

        public bool BotMmEnabled
        {
            get { return botMmEnabled; }
            set { botMmEnabled = value; }
        }
        private int defenseRank;  //Champion defense rank.

        public int DefenseRank
        {
            get { return defenseRank; }
            set { defenseRank = value; }
        }
        private int difficultyRank;  //Champion difficulty rank.

        public int DifficultyRank
        {
            get { return difficultyRank; }
            set { difficultyRank = value; }
        }
        private bool freeToPlay;  //Indicates if the champion is free to play. Free to play champions are rotated periodically.

        public bool FreeToPlay
        {
            get { return freeToPlay; }
            set { freeToPlay = value; }
        }
        private long id;  //Champion ID.

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private int magicRank;  //Champion magic rank.

        public int MagicRank
        {
            get { return magicRank; }
            set { magicRank = value; }
        }
        private string name;  //Champion name.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool rankedPlayEnabled;	 //Ranked play enabled flag.

        public bool RankedPlayEnabled
        {
            get { return rankedPlayEnabled; }
            set { rankedPlayEnabled = value; }
        }

        public ChampionDto() { }
    }
}
