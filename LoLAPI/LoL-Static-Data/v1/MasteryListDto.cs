using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.LoL_Static_Data.v1
{
    class MasteryListDto
    {
        private Dictionary<string, MasteryDto> data;
        private MasteryTreeDto tree;
        private string type;
        private string version;
    }
}
