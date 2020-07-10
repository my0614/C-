using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string text2 = textBox2.Text;
            int value = Convert.ToInt32(text);
            int value2 = Convert.ToInt32(text2);

            MessageBox.Show(Convert.ToString(value+value2));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

