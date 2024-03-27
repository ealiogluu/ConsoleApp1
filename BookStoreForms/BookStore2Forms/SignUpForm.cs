using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreForms
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = Color.Silver;
            }
        }
        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = null;
                txtName.ForeColor = Color.Black;
            }
        }
        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            if (txtName.Text == null)
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.Silver;
            }
        }
        private void txtPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "Phone Number")
            {
                txtPhoneNumber.Text = null;
                txtPhoneNumber.ForeColor = Color.Black;
            }
        }
        private void txtPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == null)
            {
                txtPhoneNumber.Text = "Phone Number";
                txtPhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void exitSignUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = null;
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }
        char? nothing = null;
        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text == null)
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.PasswordChar = Convert.ToChar(nothing);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var client = new Client();

            string name = txtName.Text;
            name = client.Name;

            string userName = txtUserName.Text;
            userName = client.UserName;

            string adress= txtAdress.Text;
            adress = client.Adress;

            string phoneNumber = txtPhoneNumber.Text;
            phoneNumber = client.PhoneNumber;  
            
            string password = txtPhoneNumber.Text;
            password = client.Password;

            BookStore2.Clients.Add(client);
            MessageBox.Show("Registration successful.");
        }
    }
}

