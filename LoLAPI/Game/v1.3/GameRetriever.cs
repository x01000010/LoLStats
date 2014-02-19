using Newtonsoft.Json;
using System.Net;

namespace LoLAPI.Game.v1._3
{
    public static class GameRetriever
    {
        private static long _summonerId = 39088285;

        public static RecentGamesDto GetGameData()
        {
            return GetGameData(StaticVariables.ApiKey, StaticVariables.Region, _summonerId);
        }

        public static RecentGamesDto GetGameData(string apiKey, long summonerId)
        {
            return GetGameData(apiKey, StaticVariables.Region, summonerId);
        }

        public static RecentGamesDto GetGameData(string apiKey, string region, long summonerId)
        {
            ///api/lol/{region}/v1.3/game/by-summoner/{summonerId}/recent
            string gameApi = string.Format(@"/api/lol/{0}/v1.3/game/by-summoner/{1}/recent", region, summonerId);
            string query = string.Empty;

            apiKey = string.Format(@"api_key={0}", apiKey);
            query = string.Format("{0}{1}?{2}", StaticVariables.BaseAddress, gameApi, apiKey);
            RecentGamesDto RGD = new RecentGamesDto();
            var json = new WebClient().DownloadString(query);
            RGD = JsonConvert.DeserializeObject<RecentGamesDto>(json);
            return RGD;
        }
    }
}