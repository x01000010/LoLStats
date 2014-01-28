using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLStats
{
    class Summoner
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int profileiconid;

        public int Profileiconid
        {
            get { return profileiconid; }
            set { profileiconid = value; }
        }
        private long revisionDate;

        public long RevisionDate
        {
            get { return revisionDate; }
            set { revisionDate = value; }
        }
        private long summonerLevel;

        public long SummonerLevel
        {
            get { return summonerLevel; }
            set { summonerLevel = value; }
        }

        Summoner() { }
    }
}
