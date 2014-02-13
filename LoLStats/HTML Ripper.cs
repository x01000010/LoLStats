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
    public partial class HTML_Ripper : Form
    {
        public HTML_Ripper()
        {
            InitializeComponent();
            tb_StartAddress.Text = @"http://afterhoursgaming.tv/league-legends-season-4/teams/";
            tb_TeamXPath.Text = @"//img[@class='alignnone size-full']";


            //            http://afterhoursgaming.tv/league-legends-season-4/teams/?page=1

            /*
             * namespace HTML_Ripper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            
            string htmlCode = client.DownloadString(@"http://afterhoursgaming.tv/league-legends-season-4/teams/");
HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(htmlCode);
            foreach (HtmlNode node in document.DocumentNode.SelectNodes(@"//img[@class='alignnone size-full']")){
                
                for (int idx = 0; idx < node.Attributes.Count; idx++)                
                {
                    HtmlAttribute h = node.Attributes[idx];
                    if (string.Compare(h.Name.ToString(),"alt")==0){
                    Console.WriteLine(h.Value.ToString());
                    }
                }
            }
            
        }

        
    }
}
             */
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string pageAddon = "?page=";
            string baseWebAddress = tb_StartAddress.Text;
            List<string> pagesToGoThrough = new List<string>();

            bool pageExists = true;
            int count = 1;

            while (pageExists)
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(string.Format(string.Format(@"{0}{1}{2}", baseWebAddress, pageAddon, count)));
               
                webRequest.Method = WebRequestMethods.Http.Head;
                try
                {
                    using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                    {
                        pageExists = webResponse.StatusCode == HttpStatusCode.OK;
                        Console.WriteLine(string.Format(string.Format(@"{0}{1}{2}", baseWebAddress, pageAddon, count)));
                    }
                }
                catch
                {
                    pageExists = false;
                }
                count++;
            }
        }
    }
}
