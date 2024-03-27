using BookStoreForms.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreForms.BookStore
{
    public partial class UserLogIn : Form
    {
        public UserLogIn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void userNameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "User Name")
            {
                userNameTextBox.Text = null;
                userNameTextBox.ForeColor = Color.Black;
            }
        }
        private void userNameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == null)
            {
                userNameTextBox.Text = "User Name";
                userNameTextBox.ForeColor = Color.Silver;
            }
        }
        char? none = null;
        private void passwordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "User Name")
            {
                passwordTextBox.Text = null;
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }
        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == null)
            {
                passwordTextBox.Text = "User Name";
                passwordTextBox.ForeColor = Color.Silver;
                passwordTextBox.PasswordChar = Convert.ToChar(none);
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            //var store = new BookStore();

            foreach (Client client in BookStore2.Clients)
            {
                if (userName == client.Name)
                {
                    if (password == client.Password)
                    {
                        var main = new Main();
                        
                        //lblAccount.
                        return;
                    }
                    else MessageBox.Show("Password is wrong.");
                }
                else MessageBox.Show("User name is wrong.");
            }
        }
    }
}
