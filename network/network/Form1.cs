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
         
        }
    }
}
