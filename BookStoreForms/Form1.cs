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

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Client client in BookStore.Clients)
            {
                if (userName.Text == "Azra")
                {
                    if (password.Text == "123")
                    {
                        result.Text = "Log in successful.";
                    }
                    else result.Text = "Password is wrong.";
                }

                else result.Text = "User name is worng!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
