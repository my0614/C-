
namespace clickevent
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        int index;
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::clickevent.Properties.Resources.거품;
            this.pictureBox1.Location = new System.Drawing.Point(389, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 475);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        void PictureArray(int count)
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox[count];
            for(int index=0;index < pictureBox2.Length; index++)
            {
                this.pictureBox2[index] = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2[index])).BeginInit();
                this.pictureBox2[index].Image = global::clickevent.Properties.Resources.세균;
                this.pictureBox2[index].Location = new System.Drawing.Point(12 , 12);
                this.pictureBox2[index].Name = "pictureBox2";
                this.pictureBox2[index].Size = new System.Drawing.Size(100, 50);
                this.pictureBox2[index].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pictureBox2[index].TabIndex = 1;
                this.pictureBox2[index].TabStop = false;
                this.Controls.Add(this.pictureBox2[index]);
                this.pictureBox2[index].Click += new System.EventHandler(this.pictureBox2_Click);
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2[index])).EndInit();
            }
            
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox[] pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

