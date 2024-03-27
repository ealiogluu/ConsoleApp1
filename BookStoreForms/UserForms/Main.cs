using BookStoreForms.BookStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreForms.UserForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtBasket_TextChanged(object sender, EventArgs e)
        {
            txtBasket.TextAlign = HorizontalAlignment.Center;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;

            foreach (Book book in BookStore2.Books)
            {
                if (search == book.Name)
                {
                }
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserLogIn userLogIn = new UserLogIn();
            userLogIn.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();       
            signUp.ShowDialog();

        }
    }
}

   

