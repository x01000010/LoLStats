using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI
{
    class LeagueDto
    {
        private LeagueItemDto[] entries;

        public LeagueItemDto[] Entries
        {
            get { return entries; }
            set { entries = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string participantId;

        public string ParticipantId
        {
            get { return participantId; }
            set { participantId = value; }
        }
        private string queue;  //(legal values: RANKED_SOLO_5x5, RANKED_TEAM_3x3, RANKED_TEAM_5x5)

        public string Queue
        {
            get { return queue; }
            set { queue = value; }
        }
        private string tier;  //(legal values: CHALLENGER, DIAMOND, PLATINUM, GOLD, SILVER, BRONZE)

        public string Tier
        {
            get { return tier; }
            set { tier = value; }
        }

        LeagueDto() { }
    }
}
