using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Summoner
{
    class RunePagesDto
    {
        private RunePageDto[] pages;  //Set of rune pages associated with the summoner.

        public RunePageDto[] Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        private long summonerId;  //Summoner ID.

        public long SummonerId
        {
            get { return summonerId; }
            set { summonerId = value; }
        }

        RunePagesDto() { }
    }
}
