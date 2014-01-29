using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Summoner
{
    class RuneDto
    {
        private string description;  //Rune description.

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int id;  //Rune ID.

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;  //Rune name.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int tier;  //Rune tier.

        public int Tier
        {
            get { return tier; }
            set { tier = value; }
        }

        RuneDto() { }
    }
}
