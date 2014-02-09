using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoLAPI
{
    public class ChampionListDto
    {
        private ChampionDto[] champions;

        public ChampionDto[] Champions
        {
            get { return champions; }
            set { champions = value; }
        }

        
        public ChampionListDto(
            ) {
                champions = null;
        }
    }
}
