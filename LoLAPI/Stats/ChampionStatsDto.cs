using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Stats
{
    class ChampionStatsDto
    {
        private int id;  //Champion id.

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;  //Champion name.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private AggregatedStatsDto[] stats;  //Aggregated stats associated with the champion.

        internal AggregatedStatsDto[] Stats
        {
            get { return stats; }
            set { stats = value; }
        }

        ChampionStatsDto() { }
    }
}
