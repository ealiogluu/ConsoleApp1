using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStoreForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            foreach (Client client in BookStore.Clients)
            {
                if (userName == client.Name)
                {
                    if (password == client.Password)
                    {
                        resultLabel.Text = "Log in successful.";
                    }
                    else resultLabel.Text = "Password is wrong.";
                }
                else resultLabel.Text = "User name is worng!";
            }

        }
    }
}
