using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI
{
    internal static class StaticVariables
    {
        private static string _apiKey = "e480e552-bfbe-4b4c-9ce4-329beaf06233";

        internal static string ApiKey
        {
            get { return StaticVariables._apiKey; }            
        }
        private static string _region = "na";

        internal static string Region
        {
            get { return StaticVariables._region; }            
        }
        private static string _baseAddress = @"https://prod.api.pvp.net";

        internal static string BaseAddress
        {
            get { return StaticVariables._baseAddress; }
                    }
    }
}
