using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.Summoner
{
    class RunePageDto
    {
        private bool current;  //Indicates if the page is the current page.

        public bool Current
        {
            get { return current; }
            set { current = value; }
        }
        private long id;  //Rune page ID.

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;  //Rune page name.

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private RuneSlotDto[] slots;  //List of rune slots associated with the rune page.

        internal RuneSlotDto[] Slots
        {
            get { return slots; }
            set { slots = value; }
        }

        RunePageDto() { }
    }
}
