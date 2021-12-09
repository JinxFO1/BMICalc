using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BMICalc
{
    public partial class Form1 : Form
    {
        bool LoggedIn = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void BmiCalc_Click(object sender, EventArgs e)
        {
            //init
            float Weight = float.Parse(WeightTxt.Text);
            float Height = float.Parse(HeightTxt.Text);




            //input

            bool resultWeight, resultHeight = false;
            resultWeight = float.TryParse(WeightTxt.Text, out Weight);
            resultHeight = float.TryParse(HeightTxt.Text, out Height);

            if (resultWeight && resultHeight) ;

            if (Weight >= 25 && Weight <= 300 && Height >= 0.60f && Height <= 3)
            {

                //process
                float bmi = Weight / (Height * Height);
                string cat = "";
                if (bmi < 18.5) { cat = "Underweight"; }
                if (bmi > 18.5 && bmi <= 25) { cat = "Average"; }
                if (bmi > 25 && bmi <= 30) { cat = "Overweight"; }
                if (bmi > 30) { cat = "Rather Large"; }

                //output
                ReturnTxt.Text = bmi.ToString() + "      " + cat + "\r\n";
                HistoryRTB.AppendText(bmi.ToString() + "      " + cat + "\r\n");



                //file Output

                try
                {
                    StreamWriter writer = new StreamWriter(@"G:\HealthData"+Name.Text+".txt", true);
                    writer.WriteLine(DateTime.Now.ToString() + "," + bmi.ToString() + "," + cat);
                    writer.Close();
                }
                catch {
                    MessageBox.Show("man put sumn not dumb in");
                }





            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2); //colour and width
            SolidBrush brush = new SolidBrush(Color.Blue);


            e.Graphics.DrawLine(pen, new Point(10, 10), new Point(100, 100));
            //e.Graphics.DrawRectangle(pen, new Rectangle(10, 10, 200, 200));
            //e.Graphics.FillRectangle(brush, new Rectangle(10, 10, 200, 200));

            Point[] bmiPoints = new Point[10];

            bmiPoints[0] = new Point(10, 120);
            bmiPoints[1] = new Point(30, 140);
            bmiPoints[2] = new Point(50, 130);
            bmiPoints[3] = new Point(70, 140);

            for (int i = 0; i < 2; i++)
            {
                e.Graphics.DrawLine(pen, bmiPoints[i], bmiPoints[i + 1]);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object send, EventArgs e) 
        {
            //string filename = @"G:\HealthData";
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Name.Text == "")
            {
                MessageBox.Show("Please Input A Name");
            }
            else
            {
                if (File.Exists(@"G:\HealthData" + Name.Text + ".txt"))
                {
                    tabcontrol1.SelectTab(1);
                    LoggedIn = true;

                }
                else
                {
                    using (FileStream fs = File.Create(@"G:\HealthData" + Name.Text + ".txt")) ;
                    tabcontrol1.SelectTab(1);
                    LoggedIn = true;
                }
            }





        }

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol1.SelectedIndex == 1) ;
            {
                if (LoggedIn == false)
                {
                    tabcontrol1.SelectTab(0);
                    MessageBox.Show("Please Log In");
                }

            }
        }
    }
}