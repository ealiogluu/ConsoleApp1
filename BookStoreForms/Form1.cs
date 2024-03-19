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
                        MessageBox.Show("log in successful.");
                    }
                    else MessageBox.Show("Password is wrong.");
                }
                else MessageBox.Show("User name is wrong.");
            }
        }

        private void userNameTextBox_MouseEnter(object sender, EventArgs e)
        {
            userNameTextBox.Text = "UserName";
            userNameTextBox.BackColor = SystemColors.Window;

        }

        private void userNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            userNameTextBox = null;
            
        }
    }
}
