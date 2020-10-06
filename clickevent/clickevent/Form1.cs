using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickevent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            PictureArray(10);
           // timer1.Start(); // 타이머 시작 명령
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Left = e.X;
            pictureBox1.Top = e.Y;
            


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)

        {
           
           
          
        }
        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            temp.Visible = false; //숨기기 
                
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox2[0].Top == this.Height) // form1 사이즈을 넘겼을 경우
            {
                pictureBox2[0].Top = 0; // 0으로 초기화
            }
            Random rand = new Random(); // 랜덤함수 사용
            //pictureBox2[9].Top += 10;
            for(int index=0;index < pictureBox2.Length;index++)
            {
                int a = rand.Next(300); // y축
                int b = rand.Next(800); // x축

                pictureBox2[index].Top = a; // 랜덤설정
                pictureBox2[index].Left = b; // 랜덤설정
                //Thread.Sleep(500); // 딜레이 주기
                

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
