namespace LoLStats
{
    public class AHGL_Player
    {
        private string inGameName;
        private string name;
        private string teamName;
        private string webpage;

        public AHGL_Player(string name, string inGameName, string teamName, string webpage)
        {
            this.name = name;
            this.inGameName = inGameName;
            this.teamName = teamName;
            this.webpage = webpage;
        }

        public AHGL_Player(string inGameName, string teamName)
            : this(string.Empty, inGameName, teamName, string.Empty)
        {
        }

        public AHGL_Player(string inGameName, string teamName, string webpage)
            : this(string.Empty, inGameName, teamName, webpage)
        {
        }
    }
}