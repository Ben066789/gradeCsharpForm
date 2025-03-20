namespace StudentGradeApplication
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Name: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Grades";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 75);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "English";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 104);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 5;
            label4.Text = "Math";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 134);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "Science";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 163);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 7;
            label6.Text = "Filipino";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 191);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 8;
            label7.Text = "History";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(64, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(76, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(64, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(76, 125);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(64, 23);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(76, 96);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(64, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(24, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 13;
            button1.Text = "Generate Average";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(203, 128);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 14;
            label8.Text = "                  ";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(203, 113);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 15;
            label9.Text = "                  ";
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(203, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 65);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 273);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
    }
}
