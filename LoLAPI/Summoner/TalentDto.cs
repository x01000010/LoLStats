using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Summoner
{
    class TalentDto
    {
        private int id;  //Talent id.

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;  //Talent name.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int rank;  //Talent rank.

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        TalentDto() { }
    }
}
