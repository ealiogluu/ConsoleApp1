﻿using System;
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

            if (userName == "nurralioglu")
            {
                if (password == "1234")
                    labelOutCome.Text = "Log In is successful.";

                else labelOutCome.Text = "Password is wrong.";
            }

            else labelOutCome.Text= "User name is wrong."; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
