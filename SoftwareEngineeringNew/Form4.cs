using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringNew
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string user4;
        decimal b = -5;
        BusinessModel2 a = new BusinessModel2();
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            b = 5;
            user4 = Form2.user2;
            comboBoxFunction.Text = "Binomial distribution";
            chart1.ChartAreas[0].AxisX.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            for (int i = 0; i < 200; i++)
            {

                if (a.BD(5, 0.5, 1, b) <= 0) break;
                else
                {
                    chart1.Series[0].Points.AddXY(a.BD(5, 0.5, 0, b), a.BD(5, 0.5, 1, b));

                }
                b--;
            }
        }

        private void comboBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFunction.Text == "Binomial distribution")
            {
                label3.Text = "n:";
                label4.Text = "p:";
                numericUpDownV2.Visible = true;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Binomial distribution.png");
                richTextBox1.Text = "In probability theory and statistics, the binomial distribution is N independent is/non-discrete probability distribution of the number of successful trials, wherein the probability of success of each trial is P.Such a single success / failure test is also known as the Bernoulli test.In fact, when n = 1, the binomial distribution is the Bernoulli distribution.Binomial distribution is the basis for binomial experiments with significant differences.";
            }
            else
            {
                label3.Text = "λ:";
                label4.Text = " ";
                numericUpDownV2.Visible = false;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\The Poisson Distribution.png");
                richTextBox1.Text = "Poisson distribution is a discrete probability distribution commonly seen in statistics and probabilism, published by the French mathematician Simeon Denis Poisson in 1838.";
            }
        }

        private void comboBoxFunction_Click(object sender, EventArgs e)
        {
            if (user4 == "false")
            {
                comboBoxFunction.DroppedDown = false;//无法弹出下拉框
                MessageBox.Show("Sorry, you cannot use this feature.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxFunction.Text == "Binomial distribution")
            {
                chart1.Series[0].Points.Clear();
                b = numericUpDownV1.Value;
                chart1.ChartAreas[0].AxisX.Maximum = (double)numericUpDownX.Value;
                chart1.ChartAreas[0].AxisY.Maximum = (double)numericUpDownY.Value;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                for (int i = 0; i < 200; i++)
                {

                    if (a.BD((int)numericUpDownV1.Value, (double)numericUpDownV2.Value, 1, b) <= 0) break;
                    else
                    {
                        chart1.Series[0].Points.AddXY(a.BD((int)numericUpDownV1.Value, (double)numericUpDownV2.Value, 0, b), a.BD((int)numericUpDownV1.Value, (double)numericUpDownV2.Value, 1, b));
                    }
                    b--;
                }
            }
            else
            {
                chart1.Series[0].Points.Clear();
                b = numericUpDownX.Value;
                chart1.ChartAreas[0].AxisX.Maximum = (double)numericUpDownX.Value;
                chart1.ChartAreas[0].AxisY.Maximum = (double)numericUpDownY.Value;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                for (int i = 0; i < 200; i++)
                {

                    if (a.TPD((int)numericUpDownV1.Value, 1, b) <= 0) break;
                    else
                    {
                        chart1.Series[0].Points.AddXY(a.TPD((int)numericUpDownV1.Value, 0, b), a.TPD((int)numericUpDownV1.Value, 1, b));
                    }
                    b--;
                }
            }
        }
    }
    class BusinessModel2
    {
        int a1 = 0;
        public decimal BD(int n, double p, int a, decimal b)
        {
            decimal x = 0, y = 0;
            for (int i = 0; i <= b; i++)
            {
                x = i;
                double x1 = Math.Pow(p, i);
                double x2 = Math.Pow(1 - p, n - i);
                y = (decimal)(jiecheng(n) * x1 * x2 / (jiecheng(i) * jiecheng(n - i)));
            }
            a1 = a;
            if (a1 == 0) return x;
            else return y;

        }
        public decimal TPD(int n, int a, decimal b)
        {
            decimal x = 0, y = 0;
            for (int i = 0; i < b; i++)
            {
                x = i;
                y = (decimal)(Math.Pow(n, i) * Math.Exp(-n) / jiecheng(i));
            }
            a1 = a;
            if (a1 == 0) return x;
            else return y;
        }
        public int jiecheng(int i)
        {
            int a = 1;
            for (int j = 1; j <= i; j++) a *= j;
            return a;
        }
    }
}
