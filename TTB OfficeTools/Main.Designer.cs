namespace TTB_OfficeTools
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.title2_text = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.about_bt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.title1_text = new System.Windows.Forms.Label();
            this.close_bt = new System.Windows.Forms.Panel();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(196)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(196)))), ((int)(((byte)(129)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.button1.Location = new System.Drawing.Point(112, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Excel 데이터로 변환";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title2_text
            // 
            this.title2_text.AutoSize = true;
            this.title2_text.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.title2_text.Location = new System.Drawing.Point(7, 46);
            this.title2_text.Name = "title2_text";
            this.title2_text.Size = new System.Drawing.Size(85, 38);
            this.title2_text.TabIndex = 1;
            this.title2_text.Text = "OfficeTools\r\n1.0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(112, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 320);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "---예시 데이터---\r\n\r\n씨샵\r\n567\r\n자바\r\n45\r\n씨플플\r\n4567\r\n자바스크립트\r\n53";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(324, 11);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 320);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "---예시 데이터---\r\n\r\n씨샵     567\r\n자바     45\r\n씨플플      4567\r\n자바스크립트     53";
            // 
            // about_bt
            // 
            this.about_bt.BackColor = System.Drawing.Color.RoyalBlue;
            this.about_bt.FlatAppearance.BorderSize = 0;
            this.about_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_bt.Location = new System.Drawing.Point(0, 360);
            this.about_bt.Name = "about_bt";
            this.about_bt.Size = new System.Drawing.Size(100, 40);
            this.about_bt.TabIndex = 4;
            this.about_bt.Text = "정보";
            this.about_bt.UseVisualStyleBackColor = false;
            this.about_bt.Click += new System.EventHandler(this.about_bt_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(196)))), ((int)(((byte)(129)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(196)))), ((int)(((byte)(129)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.button2.Location = new System.Drawing.Point(324, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "데이터 복사";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu_panel.Controls.Add(this.close_bt);
            this.menu_panel.Controls.Add(this.title1_text);
            this.menu_panel.Controls.Add(this.title2_text);
            this.menu_panel.Controls.Add(this.about_bt);
            this.menu_panel.ForeColor = System.Drawing.Color.White;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(100, 400);
            this.menu_panel.TabIndex = 6;
            // 
            // title1_text
            // 
            this.title1_text.AutoSize = true;
            this.title1_text.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.title1_text.Location = new System.Drawing.Point(4, 4);
            this.title1_text.Name = "title1_text";
            this.title1_text.Size = new System.Drawing.Size(66, 37);
            this.title1_text.TabIndex = 2;
            this.title1_text.Text = "TTB";
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.Red;
            this.close_bt.Location = new System.Drawing.Point(74, 13);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(25, 25);
            this.close_bt.TabIndex = 5;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(535, 400);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "TTB OfficeTools";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title2_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button about_bt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Label title1_text;
        private System.Windows.Forms.Panel close_bt;
    }
}

