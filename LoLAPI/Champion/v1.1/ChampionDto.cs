namespace LoLAPI.Champion.v1._1
{
    public class ChampionDto
    {
        private bool active;  //Indicates if the champion is active.
        private int attackRank;  //Champion attack rank.
        private bool botEnabled;  //Bot enabled flag (for custom games).
        private bool botMmEnabled;  //Bot Match Made enabled flag (for Co-op vs. AI games).
        private int defenseRank;  //Champion defense rank.
        private int difficultyRank;  //Champion difficulty rank.
        private bool freeToPlay;  //Indicates if the champion is free to play. Free to play champions are rotated periodically.
        private long id;  //Champion ID.
        private int magicRank;  //Champion magic rank.
        private string name;  //Champion name.
        private bool rankedPlayEnabled;	 //Ranked play enabled flag.

        #region Get/Set

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public int AttackRank
        {
            get { return attackRank; }
            set { attackRank = value; }
        }

        public bool BotEnabled
        {
            get { return botEnabled; }
            set { botEnabled = value; }
        }

        public bool BotMmEnabled
        {
            get { return botMmEnabled; }
            set { botMmEnabled = value; }
        }

        public int DefenseRank
        {
            get { return defenseRank; }
            set { defenseRank = value; }
        }

        public int DifficultyRank
        {
            get { return difficultyRank; }
            set { difficultyRank = value; }
        }

        public bool FreeToPlay
        {
            get { return freeToPlay; }
            set { freeToPlay = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public int MagicRank
        {
            get { return magicRank; }
            set { magicRank = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool RankedPlayEnabled
        {
            get { return rankedPlayEnabled; }
            set { rankedPlayEnabled = value; }
        }

        #endregion Get/Set

        public ChampionDto()
        {
        }
    }
}