using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI
{
    class ChampionListDto
    {
        private ChampionDto[] champions;

        internal ChampionDto[] Champions
        {
            get { return champions; }
            set { champions = value; }
        }
        ChampionListDto() { }
    }
}
