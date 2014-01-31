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

namespace LoLStats
{
    public partial class Form2 : Form
    {
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
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand com = new SQLiteCommand(sql, c);
            com.ExecuteNonQuery();
            c.Close();
        }
    }
}
