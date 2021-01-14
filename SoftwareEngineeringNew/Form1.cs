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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string user = " ";//在第二个窗体用来判断是用户还是访客。
        string name = "admin";
        string password = "123456";

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == name && textBoxPassword.Text == password)
            {
                Form2 form2 = new Form2();
                user = "true";
                form2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Wrong account or password!", "Wrong!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void buttonVisitor_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            user = "false";
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
