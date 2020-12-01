using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;

namespace trans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Translate(string query)
        {
            string url = "https://openapi.naver.com/v1/papago/n2mt";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "E2oUjPy85SLNpwlAL6fG");
            request.Headers.Add("X-Naver-Client-Secret", "vIi4GAlVms");
            request.Method = "POST";

            byte[] byteDataParams = Encoding.UTF8.GetBytes("source=ko&target=en&text=" + query);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();
            textBox2.Text += (text.Split(',')[5].Split(':')[1] + "\r\n");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = "";
            string[] InputStirng = textBox1.Text.Split('\n');
            for(int i=0; i<InputStirng.Length;i++)
            {
                Translate(InputStirng[i]);
            }
        }
        
    }
}
