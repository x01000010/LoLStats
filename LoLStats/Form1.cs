using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLStats
{
    public partial class Form1 : Form
    {
        private string _apiKey;
        private string _baseAddress;
        private string _region;

        private List<OLDChampionDto> _championList;

        public Form1()
        {
            InitializeComponent();
            _apiKey = "api_key=e480e552-bfbe-4b4c-9ce4-329beaf06233";
            _region = "na";
            _baseAddress = @"https://prod.api.pvp.net";

            //check champion list for what we already have
            _championList = new List<OLDChampionDto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apiCall = string.Format(@"/api/lol/{0}/v1.1/champion", _region);
            string query = string.Empty;
            string freeToPlay = String.Empty;

            if (string.Compare(freeToPlay.ToLower(), "false") == 0 || string.Compare(freeToPlay.ToLower(), "true") == 0)
            {
                string ftp = string.Format("freeToPlay={0}", freeToPlay);
                query = string.Format("{0}{1}?{3}?{2}", _baseAddress, apiCall, _apiKey,ftp);
            }
            else
            {
                query = string.Format("{0}{1}?{2}", _baseAddress, apiCall, _apiKey);
            }

            var json = new WebClient().DownloadString(query);
            JsonChamps champs = JsonConvert.DeserializeObject<JsonChamps>(json);            

            _championList = new List<OLDChampionDto>(champs.championArray);
            foreach (OLDChampionDto c in _championList) {
                Console.WriteLine(c.toString());
                Console.WriteLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string summonerID = "39088285";
        }
    }
}
