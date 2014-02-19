using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoLStats
{
    public partial class Main_Window : Form
    {
        private string _debugDirectory = @"..\DB\";
        private string _defaultDirectiory = string.Format(@"{0}\LoLStats", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

        public Main_Window()
        {
            InitializeComponent();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_db = new OpenFileDialog();
            ofd_db.Filter = "Sqlite Files|*.d3b";
            ofd_db.FileName = "Data.d3b";
            ofd_db.InitialDirectory = string.Format(@"{0}", _defaultDirectiory);

            DialogResult result = ofd_db.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = ofd_db.FileName;
            }
        }
    }
}