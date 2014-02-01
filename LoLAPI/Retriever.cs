using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI
{
    public static class Retriever
    {
        static Retriever() { }
        
        public static ChampionListDto GetChampionList(string apiURL){
            ChampionListDto CLD = new ChampionListDto();
            var json = new WebClient().DownloadString(apiURL);
            CLD = JsonConvert.DeserializeObject<ChampionListDto>(json);    
            return CLD;
        }

        
    }
}
