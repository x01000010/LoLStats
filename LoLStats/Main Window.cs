using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LoLStats
{
    public partial class Main_Window : Form
    {




        private string _defaultDirectory = string.Format(@"{0}\LoLStats", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

        public Main_Window()
        {
            InitializeComponent();
#if DEBUG

            _defaultDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory().ToString(), @"..\..\..\DB"));
                        
#endif
            if (!(Directory.Exists(_defaultDirectory)))
            {
                Directory.CreateDirectory(_defaultDirectory);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hTMLRipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0;
            List<AHGL_Team> teamsToAdd = new List<AHGL_Team>();
            using (HTML_Ripper hr = new HTML_Ripper(x))
            {
                hr.Show();
                teamsToAdd = hr.Teams;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd_db = new SaveFileDialog();
            sfd_db.Filter = "SQLiteDatabase|*.s3db";
            sfd_db.FileName = "Data.s3db";
            sfd_db.InitialDirectory = _defaultDirectory;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_db = new OpenFileDialog();
            ofd_db.Filter = "SQLite Database|*.s3db";
            ofd_db.FileName = "Data.s3db";
            ofd_db.InitialDirectory = _defaultDirectory;

            
            

            DialogResult result = ofd_db.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = ofd_db.FileName;
            }
        }
    }
}