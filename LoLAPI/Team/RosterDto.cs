using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Team
{
    class RosterDto
    {
        private TeamMemberInfoDto[] memberList;

        internal TeamMemberInfoDto[] MemberList
        {
            get { return memberList; }
            set { memberList = value; }
        }
        private long ownerId;

        public long OwnerId
        {
            get { return ownerId; }
            set { ownerId = value; }
        }

        RosterDto() { }
    }
}
