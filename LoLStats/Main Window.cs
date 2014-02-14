using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLStats
{
    public partial class Main_Window : Form
    {
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
    }
}
