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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static decimal mark = 5;
        public string user3;
        BusinessModel a = new BusinessModel();
        decimal b = -5;
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            user3 = Form2.user2;
            comboBoxFunction.Text = "Normal distribution";
            chart1.ChartAreas[0].AxisX.Maximum = 5;
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisX.Minimum = -5;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            for (int i = 0; i < 200; i++)
            {
                b = b + 0.1m;
                if (a.HP(0.2m, 0, 1, b) <= 0) break;
                else
                {
                    chart1.Series[0].Points.AddXY(a.HP(0.2m, 0, 0, b), a.HP(0.2m, 0, 1, b));

                }
            }
        }

        private void comboBoxFunction_Click(object sender, EventArgs e)
        {
            if (user3 == "false")
            {
                comboBoxFunction.DroppedDown = false;//无法弹出下拉框
                MessageBox.Show("You have not logged in yet!");
            }
        }

        private void comboBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFunction.Text == "Normal distribution")
            {
                label3.Text = "μ:";
                label4.Text = "σ:";
                numericUpDownV1.Visible = true;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Normal distribution.png");
                richTextBox1.Text = "Normal distribution, also known as Gaussian distribution and normal distribution, is a very common continuous probability distribution. The normal distribution is very important in statistics and is often used in natural and social sciences to represent an unknown random variable.";
            }
            else if (comboBoxFunction.Text == "Uniform distribution")
            {
                label3.Text = "a:";
                label4.Text = "b:";
                numericUpDownV1.Visible = true;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Uniform distribution.png");
                richTextBox1.Text = "Continuous uniform distribution,if the continuous random variable has the following probability density function,it is said that X obeys the uniform distribution on[a,b], referred to as X~U[a,b].";
            }
            else
            {
                label3.Text = " ";
                label4.Text = "σ:";
                numericUpDownV1.Visible = false;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\The Rayleigh Distribution.png");
                richTextBox1.Text = "Rayleigh distribution,when the two components of a random two-dimensional vector was independent, with the same variance, the mean of 0 normal distribution, the modulus of the Vector was Rayleigh distribution.";
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxFunction.Text == "Normal distribution")
            {
                chart1.Series[0].Points.Clear();
                chart1.ChartAreas[0].AxisX.Maximum = (double)numericUpDownX2.Value;
                chart1.ChartAreas[0].AxisY.Maximum = (double)numericUpDownY2.Value;
                chart1.ChartAreas[0].AxisX.Minimum = (double)numericUpDownX.Value;
                chart1.ChartAreas[0].AxisY.Minimum = (double)numericUpDownY.Value;
                b = numericUpDownX.Value;
                mark = (decimal)Math.Max(Math.Abs(numericUpDownX.Value), numericUpDownX2.Value);
                for (int i = 0; i < 200; i++)
                {
                    b = b + 0.1m;
                    if (a.HP(numericUpDownV2.Value * numericUpDownV2.Value, numericUpDownV1.Value, 1, b) <= 0) break;
                    else
                    {
                        chart1.Series[0].Points.AddXY(a.HP(numericUpDownV2.Value * numericUpDownV2.Value, numericUpDownV1.Value, 0, b), a.HP(numericUpDownV2.Value * numericUpDownV2.Value, numericUpDownV1.Value, 1, b));

                    }
                }
            }
            else if (comboBoxFunction.Text == "Uniform distribution")
            {
                chart1.Series[0].Points.Clear();
                chart1.ChartAreas[0].AxisX.Maximum = (double)numericUpDownX2.Value;
                chart1.ChartAreas[0].AxisY.Maximum = (double)numericUpDownY2.Value;
                chart1.ChartAreas[0].AxisX.Minimum = (double)numericUpDownX.Value;
                chart1.ChartAreas[0].AxisY.Minimum = (double)numericUpDownY.Value;
                mark = (decimal)Math.Max(Math.Abs(numericUpDownX.Value), numericUpDownX2.Value);
                b = -mark;
                for (int i = 0; i < 200; i++)
                {
                    b = b + 0.1m;
                    if (a.PP(numericUpDownV1.Value, numericUpDownV2.Value, 1, b) <= 0) break;
                    else
                    {
                        chart1.Series[0].Points.AddXY(a.PP(numericUpDownV1.Value, numericUpDownV2.Value, 0, b), a.PP(numericUpDownV1.Value, numericUpDownV2.Value, 1, b));

                    }
                }
            }
            else
            {
                chart1.Series[0].Points.Clear();
                chart1.ChartAreas[0].AxisX.Maximum = (double)numericUpDownX2.Value;
                chart1.ChartAreas[0].AxisY.Maximum = (double)numericUpDownY2.Value;
                chart1.ChartAreas[0].AxisX.Minimum = (double)numericUpDownX.Value;
                chart1.ChartAreas[0].AxisY.Minimum = (double)numericUpDownY.Value;
                mark = (decimal)Math.Max(Math.Abs(numericUpDownX.Value), numericUpDownX2.Value);
                b = 0;
                for (int i = 0; i < 200; i++)
                {
                    b = b + 0.1m;
                    if (a.PP1(numericUpDownV2.Value * numericUpDownV2.Value, 1, b) < 0) break;
                    else
                    {
                        chart1.Series[0].Points.AddXY(a.PP1(numericUpDownV2.Value * numericUpDownV2.Value, 0, b), a.PP1(numericUpDownV2.Value * numericUpDownV2.Value, 1, b));

                    }
                }
            }
        }
        private void Form3_Resize(object sender, EventArgs e)
        {
            
        }
    }
    class BusinessModel
    {
        int a1 = 0;

        public decimal HP(decimal o, decimal u, int a, decimal b)
        {
            decimal x = 0, y = 0;
            for (decimal i = -Form3.mark; i < b; i += 0.1m)
            {
                x = i;
                decimal P = (decimal)Math.Sqrt(2 * Math.PI);
                decimal u1 = (x - u) * (x - u);
                decimal o1 = (decimal)Math.Sqrt((double)o);
                decimal e1 = (decimal)Math.Exp((double)(-u1 / (2 * o)));
                y = e1 / (o1 * P);
            }
            a1 = a;
            if (a1 == 0) return x;
            else return y;

        }
        public decimal PP(decimal m, decimal n, int a, decimal b)
        {
            decimal x = 0, y = 0;
            for (decimal i = -Form3.mark; i < n && i < b; i += 0.1m)
            {
                x = i;
                y = 1 / (n - m);
            }
            a1 = a;
            if (a1 == 0 && x >= m) return x;
            else return y;
        }

        public decimal PP1(decimal o, int a, decimal b)
        {
            decimal x = 0, y = 0;
            for (decimal i = 0; i < b; i += 0.1m)
            {
                x = i;
                decimal e1 = (decimal)Math.Exp((double)-(x * x) / (double)(2 * o));
                y = x * e1 / o;

            }
            a1 = a;
            if (a1 == 0) return x;
            else return y;
        }
    }
}
