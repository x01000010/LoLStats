using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Summoner
{
    class RuneSlotDto
    {
        private RuneDto rune;  //Rune associated with the rune slot.

        internal RuneDto Rune
        {
            get { return rune; }
            set { rune = value; }
        }
        private int runeSlotId;  //Rune slot ID.

        public int RuneSlotId
        {
            get { return runeSlotId; }
            set { runeSlotId = value; }
        }

        RuneSlotDto() { }
    }
}
