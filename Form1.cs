using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Subscribe to the Load event
            this.FormBorderStyle = FormBorderStyle.None; // Optional: Remove the border
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the desired radius for the corners
            int radius = 30;

            // Create a new GraphicsPath
            GraphicsPath path = new GraphicsPath();

            // Add a rounded rectangle to the path
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the form's region to the rounded rectangle
            this.Region = new Region(path);
        }

        private string studentName = "";
        private double englishGrade, mathGrade, scienceGrade, filipinoGrade, historyGrade;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            studentName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out englishGrade);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox6.Text, out mathGrade);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox5.Text, out scienceGrade);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox3.Text, out filipinoGrade);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox4.Text, out historyGrade);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double average = (englishGrade + mathGrade + scienceGrade + filipinoGrade + historyGrade) / 5.0;
            if (average > 75)
            {
                label9.Text = "The Student Passed.";
                label8.Text = "The general average of " + studentName + " is " + average.ToString("0.00");
                pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\23-1660-584\\Pictures\\asd.jpg");
            }
            else
            {
                label9.Text = "The Student Didn't Passed.";
                label8.Text = "The general average of " + studentName + " is " + average.ToString("0.00");
                pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\23-1660-584\\Pictures\\hasd.jpg");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
