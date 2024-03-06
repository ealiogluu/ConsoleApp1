using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if (userName == "nurralioglu" && password == "12345")
                labelOutCome.Text = "Log In is successful.";
            else if (userName != "nurralioglu")
                labelOutCome.Text = "User name is wrong.";
            else if (password != "12345")
                labelOutCome.Text = "Password is wrong.";
        }
    }
}
