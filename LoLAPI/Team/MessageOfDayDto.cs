using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Team
{
    class MessageOfDayDto
    {
        private long createDate;

        public long CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        private int version;

        public int Version
        {
            get { return version; }
            set { version = value; }
        }

        MessageOfDayDto() { }
    }
}
