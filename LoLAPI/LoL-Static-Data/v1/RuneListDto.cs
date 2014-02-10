using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.LoL_Static_Data.v1
{
    class RuneListDto
    {
        private BasicRuneDataDto basic;
        private Dictionary<string, RuneDto> data;
        private string type;
        private string version;
    }
}
