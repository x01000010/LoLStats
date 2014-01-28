using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLStats
{
    class ChampionDto
    {
        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        private int attackRank;

        public int AttackRank
        {
            get { return attackRank; }
            set { attackRank = value; }
        }
        private bool botEnabled;

        public bool BotEnabled
        {
            get { return botEnabled; }
            set { botEnabled = value; }
        }
        private bool botMmEnabled;

        public bool BotMmEnabled
        {
            get { return botMmEnabled; }
            set { botMmEnabled = value; }
        }
        private int defenseRank;

        public int DefenseRank
        {
            get { return defenseRank; }
            set { defenseRank = value; }
        }
        private int difficultyRank;

        public int DifficultyRank
        {
            get { return difficultyRank; }
            set { difficultyRank = value; }
        }
        private bool freeToPlay;

        public bool FreeToPlay
        {
            get { return freeToPlay; }
            set { freeToPlay = value; }
        }
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private int magicRank;

        public int MagicRank
        {
            get { return magicRank; }
            set { magicRank = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool rankedPlayEnabled;

        public bool RankedPlayEnabled
        {
            get { return rankedPlayEnabled; }
            set { rankedPlayEnabled = value; }
        }
        ChampionDto() { }
        public string toString() {
            string str = string.Format(
                "{0}-{1}\n\tDefense: {2}\n\tAttack: {3}\n\tMagic: {4}\n\tDifficulty: {5}\n",name,id,defenseRank,attackRank,magicRank,difficultyRank);
            return str;
        }
    }
}
