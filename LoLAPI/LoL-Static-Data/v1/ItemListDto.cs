using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.LoL_Static_Data.v1
{
    class ItemListDto
    {
        private BasicDataDto basic;
        private Dictionary<string, ItemDto> data;
        private GroupDto[] groups;
        private ItemTreeDto[] tree;
        private string type;
        private string version;
    }
}
