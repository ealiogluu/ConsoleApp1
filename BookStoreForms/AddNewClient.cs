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
    public partial class AddNewClient : Form
    {
        public AddNewClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeMenu mainMenu = new EmployeeMenu();
            mainMenu.ShowDialog(this);
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

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Text = null;
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            if (txtUserName.Text == null)
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = Color.Silver;   
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

        private void txtAdress_MouseEnter(object sender, EventArgs e)
        {
            if (txtAdress.Text == "Adress")
            {
                txtAdress.Text = null;
                txtAdress.ForeColor = Color.Black;
            }
        }

        private void txtAdress_MouseLeave(object sender, EventArgs e)
        {
            if (txtAdress.Text == null)
            {
                txtAdress.Text = "Adress";
                txtAdress.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = null;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text== null)
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var client = new Client();
            string name = txtName.Text;
            client.Name = name;

            string userName = txtUserName.Text;
            client.UserName = userName;

            string phoneNumber = txtPhoneNumber.Text;   
            client.PhoneNumber = phoneNumber;

            string adress = txtAdress.Text;
            client.Adress = adress;

            string password = txtPassword.Text;
            client.Password = password; 

            BookStore.Clients.Add(client);
        }
    }
}
