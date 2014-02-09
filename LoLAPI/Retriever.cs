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

        
        public static void GetSummonerListByName(params string[] apiURL)
        {

            Dictionary<string, SummonerDto> summonerDictionary = new Dictionary<string, SummonerDto>();
            foreach (string api in apiURL)
            {
                var json = new WebClient().DownloadString(api);
                Dictionary<string, SummonerDto> tempSummonerDictionary = JsonConvert.DeserializeObject<Dictionary<string, SummonerDto>>(json);
                foreach (KeyValuePair<string, SummonerDto> summoner in tempSummonerDictionary)
                {

                    summonerDictionary.Add(summoner.Key, summoner.Value);
                }


            }
        }
    }
}
