using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLStats
{
    public class AHGL_Team
    {
        private string name;
        private int id;
        private List<AHGL_Player> players;
        private string webpage;

        #region Public Variables

        public string Name
        {
            get { return name; }
        }

        public int Id
        {
            get { return id; }
        }

        public List<AHGL_Player> Players
        {
            get { return players; }
        }

        #endregion

        public string Webpage
        {
            get { return webpage; }
            set { webpage = value; }
        }

        #region Contstructors

        public AHGL_Team(string name, int id, string webpage)
        {
            this.name = name;
            this.id = id;
            this.webpage = webpage;
            players = new List<AHGL_Player>();
        }

        public AHGL_Team(string name, int id) : this(name, id, string.Empty) { }

        #endregion

        public void addPlayer(AHGL_Player newPlayer)
        {
            players.Add(newPlayer);
        }
    }
}
