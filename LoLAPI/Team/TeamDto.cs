using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Team
{
    class TeamDto
    {
        private DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        private string fullId;

        public string FullId
        {
            get { return fullId; }
            set { fullId = value; }
        }
        private DateTime lastGameDate;

        public DateTime LastGameDate
        {
            get { return lastGameDate; }
            set { lastGameDate = value; }
        }
        private DateTime lastJoinDate;

        public DateTime LastJoinDate
        {
            get { return lastJoinDate; }
            set { lastJoinDate = value; }
        }
        private DateTime lastJoinedRankedTeamQueueDate;

        public DateTime LastJoinedRankedTeamQueueDate
        {
            get { return lastJoinedRankedTeamQueueDate; }
            set { lastJoinedRankedTeamQueueDate = value; }
        }
        private MatchHistorySummaryDto[] matchHistory;

        internal MatchHistorySummaryDto[] MatchHistory
        {
            get { return matchHistory; }
            set { matchHistory = value; }
        }
        private MessageOfDayDto messageOfDay;

        internal MessageOfDayDto MessageOfDay
        {
            get { return messageOfDay; }
            set { messageOfDay = value; }
        }
        private DateTime modifyDate;

        public DateTime ModifyDate
        {
            get { return modifyDate; }
            set { modifyDate = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private RosterDto roster;

        internal RosterDto Roster
        {
            get { return roster; }
            set { roster = value; }
        }
        private DateTime secondLastJoinDate;

        public DateTime SecondLastJoinDate
        {
            get { return secondLastJoinDate; }
            set { secondLastJoinDate = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string tag;

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        private TeamStatSummaryDto teamStatSummary;

        internal TeamStatSummaryDto TeamStatSummary
        {
            get { return teamStatSummary; }
            set { teamStatSummary = value; }
        }
        private DateTime thirdLastJoinDate;

        public DateTime ThirdLastJoinDate
        {
            get { return thirdLastJoinDate; }
            set { thirdLastJoinDate = value; }
        }

        TeamDto() { }
    }
}
