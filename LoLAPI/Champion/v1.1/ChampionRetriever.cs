using Newtonsoft.Json;
using System.Net;

namespace LoLAPI.Champion.v1._1
{
    public static class ChampionRetriever
    {
        #region GetChampionList Calls

        //remove this one if ever released
        public static ChampionListDto GetChampionList()
        {
            return __GetChampionList(StaticVariables.ApiKey, StaticVariables.Region, string.Empty);
        }

        public static ChampionListDto GetChampionList(bool freeToPlay)
        {
            return __GetChampionList(StaticVariables.ApiKey, StaticVariables.Region, freeToPlay.ToString());
        }

        public static ChampionListDto GetChampionList(string apiKey)
        {
            return __GetChampionList(apiKey, StaticVariables.Region, string.Empty);
        }

        public static ChampionListDto GetChampionList(string apiKey, string region)
        {
            return __GetChampionList(apiKey, region, string.Empty);
        }

        public static ChampionListDto GetChampionList(string apiKey, bool freeToPlay)
        {
            return __GetChampionList(apiKey, StaticVariables.Region, freeToPlay.ToString());
        }

        public static ChampionListDto GetChampionList(string apiKey, string region, bool freeToPlay)
        {
            return __GetChampionList(apiKey, region, freeToPlay.ToString());
        }

        #endregion GetChampionList Calls

        private static ChampionListDto __GetChampionList(string apiKey, string region, string freeToPlay)
        {
            ///api/lol/{region}/v1.1/champion
            string championAPI = string.Format(@"/api/lol/{0}/v1.1/champion", region);
            string query = string.Empty;
            string ftp = string.Empty;

            apiKey = string.Format(@"api_key={0}", apiKey);
            if (string.Compare(freeToPlay.ToLower(), "false") == 0 || string.Compare(freeToPlay.ToLower(), "true") == 0)
            {
                ftp = string.Format("freeToPlay={0}&", freeToPlay);
            }
            query = string.Format("{0}{1}?{3}{2}", StaticVariables.BaseAddress, championAPI, apiKey, ftp);
            ChampionListDto CLD = new ChampionListDto();
            var json = new WebClient().DownloadString(query);
            CLD = JsonConvert.DeserializeObject<ChampionListDto>(json);
            return CLD;
        }
    }
}