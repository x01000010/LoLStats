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
     public partial class HTML_Ripper : Form
    {
        public HTML_Ripper()
        {
            InitializeComponent();
            tb_StartAddress.Text = @"http://afterhoursgaming.tv/league-legends-season-4/teams/?page=1";
            tb_TeamXPath.Text = @"/html/body/div[@id='wrapper']/div[@id='main-content']/ul/li";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //List<string>pagesToGoThrough = __getPagesWithTeams();
            string address = tb_StartAddress.Text;
            string xpath = tb_TeamXPath.Text;
            WebClient client = new WebClient();
            string htmlCode = client.DownloadString(address);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(htmlCode);
            foreach (HtmlAgilityPack.HtmlNode node in document.DocumentNode.SelectNodes(xpath))
            {

                string teamName = node.InnerText.Trim();
                HtmlAgilityPack.HtmlNode nn = node.FirstChild;
                string teamAddress = nn.Attributes["href"].Value.Trim();
                //create Team
            }
        }

        private List<String> __getPagesWithTeams()
        {
            string pageAddon = "?page=";
            string baseWebAddress = tb_StartAddress.Text;
            List<string> pagesToGoThrough = new List<string>();
            bool pageExists = true;
            int count = 1;
            while (pageExists)
            {
                string pageToTest = string.Format(@"{0}{1}{2}", baseWebAddress, pageAddon, count);
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(pageToTest);
                webRequest.Method = WebRequestMethods.Http.Head;
                try
                {
                    using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
                    {
                        pageExists = webResponse.StatusCode == HttpStatusCode.OK;
                        pagesToGoThrough.Add(pageToTest);
                    }
                }
                catch
                {
                    pageExists = false;
                }
                count++;
            }
            return pagesToGoThrough;
        }
    }
}
