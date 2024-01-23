namespace Reservation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            textBox6 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            button3 = new Button();
            label10 = new Label();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(703, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 36);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 176);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 1;
            label1.Text = "adiniz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 359);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 299);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 477);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 428);
            label3.Name = "label3";
            label3.Size = new Size(39, 28);
            label3.TabIndex = 5;
            label3.Text = "Tel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 284);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 7;
            label4.Text = "Gun";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(338, 344);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 34);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(338, 477);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 34);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 417);
            label5.Name = "label5";
            label5.Size = new Size(58, 28);
            label5.TabIndex = 9;
            label5.Text = "Tarix";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(703, 176);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 11;
            label6.Text = "Mertebe";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(703, 309);
            label7.Name = "label7";
            label7.Size = new Size(58, 28);
            label7.TabIndex = 13;
            label7.Text = "Otaq";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox2.Location = new Point(703, 357);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(135, 36);
            comboBox2.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(352, 225);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 34);
            textBox6.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(352, 176);
            label9.Name = "label9";
            label9.Size = new Size(109, 28);
            label9.TabIndex = 16;
            label9.Text = "Nefer sayi";
            // 
            // button1
            // 
            button1.Location = new Point(352, 586);
            button1.Name = "button1";
            button1.Size = new Size(282, 97);
            button1.TabIndex = 18;
            button1.Text = "Rezervasiya et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1003, 33);
            button2.Name = "button2";
            button2.Size = new Size(153, 78);
            button2.TabIndex = 19;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(689, 488);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(308, 34);
            textBox7.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(703, 428);
            label8.Name = "label8";
            label8.Size = new Size(85, 28);
            label8.TabIndex = 20;
            label8.Text = "Card no";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(993, 236);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 34);
            textBox8.TabIndex = 22;
            textBox8.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(672, 586);
            button3.Name = "button3";
            button3.Size = new Size(282, 97);
            button3.TabIndex = 23;
            button3.Text = "Hesabla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1003, 620);
            label10.Name = "label10";
            label10.Size = new Size(83, 28);
            label10.TabIndex = 24;
            label10.Text = "Mebleg";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(993, 306);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 34);
            textBox9.TabIndex = 25;
            textBox9.Text = "Gozleyir";
            textBox9.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 736);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private Label label9;
        private Button button1;
        private Button button2;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Button button3;
        private Label label10;
        private TextBox textBox9;
    }
}