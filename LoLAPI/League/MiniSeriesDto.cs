using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI
{
    class MiniSeriesDto
    {
        private int losses;

        public int Losses
        {
            get { return losses; }
            set { losses = value; }
        }
        private char[] progress;

        public char[] Progress
        {
            get { return progress; }
            set { progress = value; }
        }
        private int target;

        public int Target
        {
            get { return target; }
            set { target = value; }
        }
        private long timeLeftToPlayMillis;

        public long TimeLeftToPlayMillis
        {
            get { return timeLeftToPlayMillis; }
            set { timeLeftToPlayMillis = value; }
        }
        private int wins;

        public int Wins
        {
            get { return wins; }
            set { wins = value; }
        }

        MiniSeriesDto() { }
    }
}
