using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoLAPI;

namespace LoLStats
{
    public partial class Form2 : Form
    {
        
       string   _apiKey = "api_key=e480e552-bfbe-4b4c-9ce4-329beaf06233";
            string _region = "na";
            string _baseAddress = @"https://prod.api.pvp.net";
            
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string filename = "test";
             string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            SQLiteConnection.CreateFile(string.Format(@"{0}\{1}",path,filename));
            SQLiteConnection c = new SQLiteConnection(string.Format(@"Data Source={0}\{1};Version=3;", path, filename));

            c.Open();

            string sql = "create table Champions (active boolean, attackRank int, botEnabled boolean, botMmEnabled boolean, defenseRank int, difficultyRank int, freeToPlay boolean, id int primary key, magicRank int, name string, rankedPlayEnabled	boolean)";
            SQLiteCommand com = new SQLiteCommand(sql, c);
            com.ExecuteNonQuery();
            
            
            
            
            
            

            string championAPI = string.Format(@"/api/lol/{0}/v1.1/champion", _region);
            string query = string.Empty;
            string freeToPlay = string.Empty;
            string ftp = string.Empty;
            if (string.Compare(freeToPlay.ToLower(), "false") == 0 || string.Compare(freeToPlay.ToLower(), "true") == 0)
            {
                ftp = string.Format("freeToPlay={0}&", freeToPlay);
                
            }            
            query = string.Format("{0}{1}?{3}{2}", _baseAddress, championAPI, _apiKey, ftp);

            ChampionListDto championList = Retriever.GetChampionList(query);
            //List<ChampionDto> c = new List<ChampionDto>(championList.Champions);
            List<ChampionDto> champs = new List<ChampionDto>(championList.Champions);

            foreach (ChampionDto champ in championList.Champions) {

                string championInsert = string.Format("insert into Champions (active, attackRank, botEnabled, botMmEnabled, defenseRank, difficultyRank, freeToPlay, id, magicRank, name, rankedPlayEnabled) values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, '{9}', {10});",__boolToInt(champ.Active), champ.AttackRank, __boolToInt(champ.BotEnabled), __boolToInt(champ.BotMmEnabled), champ.DefenseRank, champ.DifficultyRank, __boolToInt(champ.FreeToPlay), champ.Id, champ.MagicRank, champ.Name, __boolToInt(champ.RankedPlayEnabled));
                com = new SQLiteCommand(championInsert, c);
                com.ExecuteNonQuery();
            }
                
                DataSet ds = new DataSet();
            var da = new SQLiteDataAdapter("select * from Champions;",c);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            c.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private int __boolToInt(bool b) {
            return (b == true) ? 1 : 0;
        }
    }
}
