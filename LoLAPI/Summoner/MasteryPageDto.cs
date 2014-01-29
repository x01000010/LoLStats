using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Summoner
{
    class MasteryPageDto
    {
        private bool current;  //Indicates if the mastery page is the current mastery page.

        public bool Current
        {
            get { return current; }
            set { current = value; }
        }
        private long id; //Mastery page ID.

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;  //Mastery page name.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private TalentDto[] talents;  //List of mastery page talents associated with the mastery page.

        internal TalentDto[] Talents
        {
            get { return talents; }
            set { talents = value; }
        }

        MasteryPageDto() { }
    }
}
