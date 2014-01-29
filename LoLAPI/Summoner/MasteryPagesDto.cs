using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Summoner
{
    class MasteryPagesDto
    {
        private HashSet<MasteryPageDto> pages;  //List of mastery pages associated with the summoner.

        internal HashSet<MasteryPageDto> Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        private long summonerId;

        public long SummonerId
        {
            get { return summonerId; }
            set { summonerId = value; }
        }

        MasteryPagesDto() { }
    }
}
