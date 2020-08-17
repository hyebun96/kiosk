namespace WindowsFormsApp2
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.drink1 = new System.Windows.Forms.Label();
            this.drink2 = new System.Windows.Forms.Label();
            this.drink3 = new System.Windows.Forms.Label();
            this.drink4 = new System.Windows.Forms.Label();
            this.InputBtn = new System.Windows.Forms.Button();
            this.기타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.snack4 = new System.Windows.Forms.Label();
            this.snack3 = new System.Windows.Forms.Label();
            this.snack2 = new System.Windows.Forms.Label();
            this.snack1 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.drink_a1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.drink_a2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.drink_a3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.drink_a4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.snack_a4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.snack_a3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.snack_a2 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.snack_a1 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.RoomNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // drink1
            // 
            this.drink1.AutoSize = true;
            this.drink1.Font = new System.Drawing.Font("굴림", 11F);
            this.drink1.Location = new System.Drawing.Point(31, 146);
            this.drink1.Name = "drink1";
            this.drink1.Size = new System.Drawing.Size(46, 15);
            this.drink1.TabIndex = 4;
            this.drink1.Text = "600원";
            // 
            // drink2
            // 
            this.drink2.AutoSize = true;
            this.drink2.Font = new System.Drawing.Font("굴림", 11F);
            this.drink2.Location = new System.Drawing.Point(140, 146);
            this.drink2.Name = "drink2";
            this.drink2.Size = new System.Drawing.Size(46, 15);
            this.drink2.TabIndex = 5;
            this.drink2.Text = "550원";
            // 
            // drink3
            // 
            this.drink3.AutoSize = true;
            this.drink3.Font = new System.Drawing.Font("굴림", 11F);
            this.drink3.Location = new System.Drawing.Point(256, 147);
            this.drink3.Name = "drink3";
            this.drink3.Size = new System.Drawing.Size(46, 15);
            this.drink3.TabIndex = 6;
            this.drink3.Text = "370원";
            // 
            // drink4
            // 
            this.drink4.AutoSize = true;
            this.drink4.Font = new System.Drawing.Font("굴림", 11F);
            this.drink4.Location = new System.Drawing.Point(354, 147);
            this.drink4.Name = "drink4";
            this.drink4.Size = new System.Drawing.Size(46, 15);
            this.drink4.TabIndex = 7;
            this.drink4.Text = "420원";
            // 
            // InputBtn
            // 
            this.InputBtn.BackColor = System.Drawing.Color.White;
            this.InputBtn.Location = new System.Drawing.Point(344, 454);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(73, 60);
            this.InputBtn.TabIndex = 17;
            this.InputBtn.Text = "주문";
            this.InputBtn.UseVisualStyleBackColor = false;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // 기타ToolStripMenuItem
            // 
            this.기타ToolStripMenuItem.Name = "기타ToolStripMenuItem";
            this.기타ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 관리자모드ToolStripMenuItem
            // 
            this.관리자모드ToolStripMenuItem.Name = "관리자모드ToolStripMenuItem";
            this.관리자모드ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(345, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 107);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(251, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(135, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // snack4
            // 
            this.snack4.AutoSize = true;
            this.snack4.Font = new System.Drawing.Font("굴림", 11F);
            this.snack4.Location = new System.Drawing.Point(354, 375);
            this.snack4.Name = "snack4";
            this.snack4.Size = new System.Drawing.Size(54, 15);
            this.snack4.TabIndex = 32;
            this.snack4.Text = "1000원";
            // 
            // snack3
            // 
            this.snack3.AutoSize = true;
            this.snack3.Font = new System.Drawing.Font("굴림", 11F);
            this.snack3.Location = new System.Drawing.Point(252, 375);
            this.snack3.Name = "snack3";
            this.snack3.Size = new System.Drawing.Size(54, 15);
            this.snack3.TabIndex = 31;
            this.snack3.Text = "1000원";
            // 
            // snack2
            // 
            this.snack2.AutoSize = true;
            this.snack2.Font = new System.Drawing.Font("굴림", 11F);
            this.snack2.Location = new System.Drawing.Point(140, 375);
            this.snack2.Name = "snack2";
            this.snack2.Size = new System.Drawing.Size(54, 15);
            this.snack2.TabIndex = 30;
            this.snack2.Text = "1000원";
            // 
            // snack1
            // 
            this.snack1.AutoSize = true;
            this.snack1.Font = new System.Drawing.Font("굴림", 11F);
            this.snack1.Location = new System.Drawing.Point(31, 375);
            this.snack1.Name = "snack1";
            this.snack1.Size = new System.Drawing.Size(54, 15);
            this.snack1.TabIndex = 29;
            this.snack1.Text = "1000원";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.InitialImage = null;
            this.pictureBox8.Location = new System.Drawing.Point(336, 232);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(73, 124);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 28;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(241, 232);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(73, 124);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 27;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.InitialImage = null;
            this.pictureBox6.Location = new System.Drawing.Point(132, 232);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(73, 124);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(25, 232);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 124);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drink_a1
            // 
            this.drink_a1.AutoSize = true;
            this.drink_a1.Location = new System.Drawing.Point(51, 179);
            this.drink_a1.Name = "drink_a1";
            this.drink_a1.Size = new System.Drawing.Size(11, 12);
            this.drink_a1.TabIndex = 34;
            this.drink_a1.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // drink_a2
            // 
            this.drink_a2.AutoSize = true;
            this.drink_a2.Location = new System.Drawing.Point(159, 179);
            this.drink_a2.Name = "drink_a2";
            this.drink_a2.Size = new System.Drawing.Size(11, 12);
            this.drink_a2.TabIndex = 37;
            this.drink_a2.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(285, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // drink_a3
            // 
            this.drink_a3.AutoSize = true;
            this.drink_a3.Location = new System.Drawing.Point(268, 179);
            this.drink_a3.Name = "drink_a3";
            this.drink_a3.Size = new System.Drawing.Size(11, 12);
            this.drink_a3.TabIndex = 40;
            this.drink_a3.Text = "0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(241, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(387, 180);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 23);
            this.button7.TabIndex = 44;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // drink_a4
            // 
            this.drink_a4.AutoSize = true;
            this.drink_a4.Location = new System.Drawing.Point(370, 185);
            this.drink_a4.Name = "drink_a4";
            this.drink_a4.Size = new System.Drawing.Size(11, 12);
            this.drink_a4.TabIndex = 43;
            this.drink_a4.Text = "0";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(343, 180);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 23);
            this.button8.TabIndex = 42;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(388, 409);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 23);
            this.button9.TabIndex = 56;
            this.button9.Text = "+";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // snack_a4
            // 
            this.snack_a4.AutoSize = true;
            this.snack_a4.Location = new System.Drawing.Point(371, 414);
            this.snack_a4.Name = "snack_a4";
            this.snack_a4.Size = new System.Drawing.Size(11, 12);
            this.snack_a4.TabIndex = 55;
            this.snack_a4.Text = "0";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(344, 409);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(21, 23);
            this.button10.TabIndex = 54;
            this.button10.Text = "-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(286, 409);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(21, 23);
            this.button11.TabIndex = 53;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // snack_a3
            // 
            this.snack_a3.AutoSize = true;
            this.snack_a3.Location = new System.Drawing.Point(269, 414);
            this.snack_a3.Name = "snack_a3";
            this.snack_a3.Size = new System.Drawing.Size(11, 12);
            this.snack_a3.TabIndex = 52;
            this.snack_a3.Text = "0";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(242, 409);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(21, 23);
            this.button12.TabIndex = 51;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(177, 409);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(21, 23);
            this.button13.TabIndex = 50;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // snack_a2
            // 
            this.snack_a2.AutoSize = true;
            this.snack_a2.Location = new System.Drawing.Point(160, 414);
            this.snack_a2.Name = "snack_a2";
            this.snack_a2.Size = new System.Drawing.Size(11, 12);
            this.snack_a2.TabIndex = 49;
            this.snack_a2.Text = "0";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(133, 409);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(21, 23);
            this.button14.TabIndex = 48;
            this.button14.Text = "-";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(69, 409);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(21, 23);
            this.button15.TabIndex = 47;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // snack_a1
            // 
            this.snack_a1.AutoSize = true;
            this.snack_a1.Location = new System.Drawing.Point(52, 414);
            this.snack_a1.Name = "snack_a1";
            this.snack_a1.Size = new System.Drawing.Size(11, 12);
            this.snack_a1.TabIndex = 46;
            this.snack_a1.Text = "0";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(25, 409);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(21, 23);
            this.button16.TabIndex = 45;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // RoomNum
            // 
            this.RoomNum.Location = new System.Drawing.Point(232, 475);
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.ReadOnly = true;
            this.RoomNum.Size = new System.Drawing.Size(100, 21);
            this.RoomNum.TabIndex = 57;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 526);
            this.Controls.Add(this.RoomNum);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.snack_a4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.snack_a3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.snack_a2);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.snack_a1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.drink_a4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.drink_a3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.drink_a2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.drink_a1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.snack4);
            this.Controls.Add(this.snack3);
            this.Controls.Add(this.snack2);
            this.Controls.Add(this.snack1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.drink4);
            this.Controls.Add(this.drink3);
            this.Controls.Add(this.drink2);
            this.Controls.Add(this.drink1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order";
            this.Text = "자판기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label drink1;
        private System.Windows.Forms.Label drink2;
        private System.Windows.Forms.Label drink3;
        private System.Windows.Forms.Label drink4;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.ToolStripMenuItem 기타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자모드ToolStripMenuItem;
        private System.Windows.Forms.Label snack4;
        private System.Windows.Forms.Label snack3;
        private System.Windows.Forms.Label snack2;
        private System.Windows.Forms.Label snack1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label drink_a1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label drink_a2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label drink_a3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label drink_a4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label snack_a4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label snack_a3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label snack_a2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label snack_a1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox RoomNum;
    }
}

