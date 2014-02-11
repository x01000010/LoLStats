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

        private string _apiKey = "api_key=e480e552-bfbe-4b4c-9ce4-329beaf06233";
            
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "test";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            SQLiteConnection.CreateFile(string.Format(@"{0}\{1}", path, filename));
            SQLiteConnection connection = new SQLiteConnection(string.Format(@"Data Source={0}\{1};Version=3;", path, filename));
            connection.Open();

            string createSummonerTable = "create table Summoners (id int primary key, name text, profileIconId int, revisionDate int, summonerLevel int)";
            SQLiteCommand command = new SQLiteCommand();
            command = new SQLiteCommand(createSummonerTable, connection);
            command.ExecuteNonQuery();

       
                        string summoner= "x01000010";
            //string championAPI = string.Format(@"/api/lol/{0}/v1.3/summoner/by-name/{1}", _region,summoner);
        string summonerQuery = string.Empty;
        //summonerQuery = string.Format(@"{0}/{1}?{2}",_baseAddress,championAPI,_apiKey);
        Console.WriteLine(summonerQuery);
        Dictionary<string, SummonerDto> l = new Dictionary<string, SummonerDto>();

        //l = Retriever.
            Retriever.GetSummonerListByName(summonerQuery);
        
        
        
        
        
        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private int __boolToInt(bool b) {
            return (b == true) ? 1 : 0;
        }

        private void __loadChampions() {
            string filename = "test";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            SQLiteConnection.CreateFile(string.Format(@"{0}\{1}", path, filename));
            SQLiteConnection c = new SQLiteConnection(string.Format(@"Data Source={0}\{1};Version=3;", path, filename));

            c.Open();

            string sql = "create table Champions (active boolean, attackRank int, botEnabled boolean, botMmEnabled boolean, defenseRank int, difficultyRank int, freeToPlay boolean, id int primary key, magicRank int, name string, rankedPlayEnabled	boolean)";
            SQLiteCommand com = new SQLiteCommand(sql, c);
            com.ExecuteNonQuery();







            

            ChampionListDto championList =LoLAPI.ChampionRetriever.GetChampionList();            
            List<ChampionDto> champs = new List<ChampionDto>(championList.Champions);

            foreach (ChampionDto champ in championList.Champions)
            {

                string championInsert = string.Format("insert into Champions (active, attackRank, botEnabled, botMmEnabled, defenseRank, difficultyRank, freeToPlay, id, magicRank, name, rankedPlayEnabled) values ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, '{9}', {10});", __boolToInt(champ.Active), champ.AttackRank, __boolToInt(champ.BotEnabled), __boolToInt(champ.BotMmEnabled), champ.DefenseRank, champ.DifficultyRank, __boolToInt(champ.FreeToPlay), champ.Id, champ.MagicRank, champ.Name, __boolToInt(champ.RankedPlayEnabled));
                com = new SQLiteCommand(championInsert, c);
                com.ExecuteNonQuery();
            }

            DataSet ds = new DataSet();
            var da = new SQLiteDataAdapter("select * from Champions;", c);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            c.Close();
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RecentGamesDto rd = GameRetriever.GetGameData();
            button1.Show();
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
