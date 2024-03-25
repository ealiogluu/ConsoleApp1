using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            //var store = new BookStore();

            foreach (Client client in BookStore.Clients)
            {
                if (userName == client.Name)
                {
                    if (password == client.Password)
                    {
                        MessageBox.Show("log in successful.");
                        return;
                    }
                    else MessageBox.Show("Password is wrong.");
                }
                else MessageBox.Show("User name is wrong.");
            }
        }

        private void userNameTextBox_MouseEnter(object sender, EventArgs e)
        {

            if (userNameTextBox.Text== "UserName")
            {
                userNameTextBox.Text = null;
                userNameTextBox.ForeColor = Color.Black;
            }
        }

        private void userNameTextBox_MouseLeave(object sender, EventArgs e)
        {
   
            if (userNameTextBox.Text == null )
            { 
                userNameTextBox.Text = "UserName";
                userNameTextBox.ForeColor = Color.Silver;
            }
            
        }

        private void passwordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = null;
                passwordTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == null)
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Silver;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start();
        }
    }
}
