using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickevent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            PictureArray(10);
            timer1.Start(); // 타이머 시작 명령
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Left = e.X;
            pictureBox1.Top = e.Y;
            pictureBox2[10].Left = e.Y;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Left)
                pictureBox1.Left -= 10; //왼쪽으로 이동
            if (e.KeyCode == Keys.Right)
                pictureBox1.Left += 10; //오른쪽으로 이동
            if (e.KeyCode == Keys.Down)
                pictureBox1.Top += 10; //위로 이동
            if (e.KeyCode == Keys.Up)
                pictureBox1.Top -= 10; //아래로 이동
           
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2[9].Top += 10;

        }
    }
}
