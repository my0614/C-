
namespace seat
{
    
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        // panel배열 만들기
        private void PanelArray(int value)
        {
            num_panel = new System.Windows.Forms.Panel[value];
            numlabel = new System.Windows.Forms.Label[value];

            for(int index = 0; index<value; index++)
            {
                this.num_panel[index] = new System.Windows.Forms.Panel();
                this.numlabel[index] = new System.Windows.Forms.Label();
                this.num_panel[index].SuspendLayout();
                this.num_panel[index].BackColor = System.Drawing.SystemColors.ScrollBar;
                this.num_panel[index].Controls.Add(this.numlabel[index]);
                this.num_panel[index].Location = new System.Drawing.Point(12+ 125 *(index%4), 25 + 80 * (index / 4));
                this.num_panel[index].Name = "num_panel";
                this.num_panel[index].Size = new System.Drawing.Size(110, 60);
                this.num_panel[index].TabIndex = 0;
                this.num_panel[index].Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
                this.numlabel[index].AutoSize = true;
                this.numlabel[index].Font = new System.Drawing.Font("굴림", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                this.numlabel[index].Location = new System.Drawing.Point(41, 27);
                this.numlabel[index].Name = "numlabel";
                this.numlabel[index].Size = new System.Drawing.Size(40, 18);
                this.numlabel[index].TabIndex = 0;
                this.numlabel[index].Text = ""+(1+index);
                this.numlabel[index].Click += new System.EventHandler(this.label1_Click);
                this.Controls.Add(this.num_panel[index]);
                this.num_panel[index].ResumeLayout(false);
                this.num_panel[index].PerformLayout();
            }

        }
        private System.Windows.Forms.Panel[] num_panel;
        private System.Windows.Forms.Label[] numlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

