using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_GenerateTestScores_
{
    public partial class frmGenerateTestScores : Form
    {

        public Random rand = new Random();

        //double x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
        double mean = 00.0;
        double SD = 00.00;
        


        public frmGenerateTestScores()
        {
            InitializeComponent();
        }

        private void grpBoxScores1_Enter(object sender, EventArgs e)
        {

        }

        private void grpBoxScores2_Enter(object sender, EventArgs e)
        {
         
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int x1 = rand.Next(50, 101);
            int x2 = rand.Next(50, 101);
            int x3 = rand.Next(50, 101);
            int x4 = rand.Next(50, 101);
            int x5 = rand.Next(50, 101);

            txtT1.Text = x1.ToString();
            txtT2.Text = x2.ToString();
            txtT3.Text = x3.ToString();
            txtT4.Text = x4.ToString();
            txtT5.Text = x5.ToString();

            int x6 = rand.Next(30, 101);
            int x7 = rand.Next(30, 101);
            int x8 = rand.Next(30, 101);
            int x9 = rand.Next(30, 101);
            int x10 = rand.Next(30, 101);

            txtT6.Text = x6.ToString();
            txtT7.Text = x7.ToString();
            txtT8.Text = x8.ToString();
            txtT9.Text = x9.ToString();
            txtT10.Text = x10.ToString();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtT1.Text = "";
            txtT2.Text = "";
            txtT3.Text = "";
            txtT3.Text = "";
            txtT4.Text = "";
            txtT5.Text = "";
            txtT6.Text = "";
            txtT7.Text = "";
            txtT8.Text = "";
            txtT9.Text = "";
            txtT10.Text = "";
            txtSD.Text = "";
            txtMean.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //int s1;

            //s1 = 10;

            double x1 = double.Parse(txtT1.Text);
            double x2 = double.Parse(txtT2.Text);
            double x3 = double.Parse(txtT3.Text);
            double x4 = double.Parse(txtT4.Text);
            double x5 = double.Parse(txtT5.Text);
            double x6 = double.Parse(txtT6.Text);
            double x7 = double.Parse(txtT7.Text);
            double x8 = double.Parse(txtT8.Text);
            double x9 = double.Parse(txtT9.Text);
            double x10 = double.Parse(txtT10.Text);

            //txtMean.Text =


            //mean = 0.00.
            mean = (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10) / 10.0;
            txtMean.Text = mean.ToString();

            double sumOfSquares = x1 * x1 + x2 * x2 + 
                x3 * x3 + x4 * x4 + x5 * x5 + x6 * x6 + x7 * x7 + x8 * x8 
                + x9 * x9 + x10 * x10;
            double temp_sd = sumOfSquares / 10;
            double temp_sd2 = temp_sd - mean * mean;

            SD = Math.Sqrt(temp_sd2);
          txtSD.Text = temp_sd2.ToString("0.00");

            //SD.ToString("0.00");
            //SD.ToString("0.00");
        }
    }
}
