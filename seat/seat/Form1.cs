using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //PanelArray(20);
            //RandomSeat();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void RandomSeat()
        {
            Random rand = new Random();

            for(int i = 0; i < numlabel.Length; i++)
            {
                int k =  rand.Next(0, numlabel.Length);
                string a = this.numlabel[i].Text;
                this.numlabel[i].Text = this.numlabel[k].Text;
                this.numlabel[k].Text = a;

            }
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = 0;
            try
            {
                temp = int.Parse(textBox1.Text);
            }catch
            {
                MessageBox.Show("숫자만 입력하세요.");
            }

            PanelArray(temp);
            RandomSeat();


        }
    }
}
