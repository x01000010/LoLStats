using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Team
{
    class TeamStatSummaryDto
    {
        private string fullId;

        public string FullId
        {
            get { return fullId; }
            set { fullId = value; }
        }
        private HashSet<TeamStatDetailDto> teamStatDetails;

        internal HashSet<TeamStatDetailDto> TeamStatDetails
        {
            get { return teamStatDetails; }
            set { teamStatDetails = value; }
        }

        TeamStatSummaryDto() { }
    }
}
