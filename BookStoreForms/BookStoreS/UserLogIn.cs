using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
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

                        return;
                    }
                    else MessageBox.Show("Password is wrong.");
                }
                else MessageBox.Show("User name is wrong.");
            }
        }
    }
}
