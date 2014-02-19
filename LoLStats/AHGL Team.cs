using System.Collections.Generic;

namespace LoLStats
{
    public class AHGL_Team
    {
        private int id;
        private string name;
        private List<AHGL_Player> players;
        private string webpage;

        #region Public Variables

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public List<AHGL_Player> Players
        {
            get { return players; }
        }

        public string Webpage
        {
            get { return webpage; }
            set { webpage = value; }
        }

        #endregion Public Variables

        #region Contstructors

        public AHGL_Team(string name, int id, string webpage)
        {
            this.name = name;
            this.id = id;
            this.webpage = webpage;
            players = new List<AHGL_Player>();
        }

        public AHGL_Team(string name, int id)
            : this(name, id, string.Empty)
        {
        }

        #endregion Contstructors

        public void addPlayer(AHGL_Player newPlayer)
        {
            players.Add(newPlayer);
        }
    }
}