using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLAPI.LoL_Static_Data.v1
{
    class RealmDto
    {
    }
}
cdn	string	The base CDN url.
css	string	Latest changed version of Dragon Magic's css file.
dd	string	Latest changed version of Dragon Magic.
l	string	Default language for this realm.
lg	string	Legacy script mode for IE6 or older.
n	Map[string, string]	Latest changed version for each data type listed.
profileiconmax	int	Special behavior number identifying the largest profileicon id that can be used under 500. Any profileicon that is requested between this number and 500 should be mapped to 0.
store	string	Additional api data drawn from other sources that may be related to data dragon functionality.
v	string	Current version of this file for this realm.