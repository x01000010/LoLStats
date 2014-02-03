using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI
{
    public class SummonerDto
    {
        private long id;  //Summoner ID.

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;  //Summoner name.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int profileIconId;  //ID of the summoner icon associated with the summoner.

        public int ProfileIconId
        {
            get { return profileIconId; }
            set { profileIconId = value; }
        }
        private long revisionDate;  //Date summoner was last modified specified as epoch milliseconds.

        public long RevisionDate
        {
            get { return revisionDate; }
            set { revisionDate = value; }
        }
        private long summonerLevel;  //Summoner level associated with the summoner.

        public long SummonerLevel
        {
            get { return summonerLevel; }
            set { summonerLevel = value; }
        }

        public SummonerDto() { }
    }
}
