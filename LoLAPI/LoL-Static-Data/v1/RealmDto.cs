using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.LoL_Static_Data.v1
{
    class RealmDto
    {
        private string cdn;  //The base CDN url.
        private string css;  //Latest changed version of Dragon Magic's css file.
        private string dd;  //Latest changed version of Dragon Magic.
        private string l;  //Default language for this realm.
        private string lg;  //Legacy script mode for IE6 or older.
        private Dictionary<string, string> n;  //Latest changed version for each data type listed.
        private int profileiconmax;  //Special behavior number identifying the largest profileicon id that can be used under 500. Any profileicon that is requested between this number and 500 should be mapped to 0.
        private string store;  //Additional api data drawn from other sources that may be related to data dragon functionality.
        private string v;  //Current version of this file for this realm.
    }
}
