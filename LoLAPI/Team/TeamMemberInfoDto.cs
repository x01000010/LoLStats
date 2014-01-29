using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Team
{
    class TeamMemberInfoDto
    {
        private DateTime inviteDate;

        public DateTime InviteDate
        {
            get { return inviteDate; }
            set { inviteDate = value; }
        }
        private DateTime joinDate;

        public DateTime JoinDate
        {
            get { return joinDate; }
            set { joinDate = value; }
        }
        private long playerId;

        public long PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        TeamMemberInfoDto() { }
    }
}
