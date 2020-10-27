using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace network
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.AbsoluteUri != e.Url.AbsoluteUri)
            {
                return;
            }


            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            Stream docStream = this.webBrowser1.DocumentStream;
            StreamReader streamReader = new StreamReader(docStream, System.Text.Encoding.GetEncoding(webBrowser1.Document.Encoding));
            string strHtml = streamReader.ReadToEnd();
            HtmlNode parseNode = doc.DocumentNode.
                 SelectSingleNode("//div[@class='box_type_l']").
                 SelectSingleNode("//table[@class='type_2']");
            List<List<string>> parsedTbl = parseNode
                                .Descendants("tr")
                                .Skip(1) //To Skip Table Header Row
                                .Where(tr => tr.Elements("td").Count() > 1)
                                .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                                .ToList();

            List<List<string>> parsedTbl2 = parseNode
                               .Descendants("tr")
                               .Skip(1) //To Skip Table Header Row
                               .Where(tr => tr.Elements("td").Count() > 1)
                               .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                               .ToList();

        }
    }
}
