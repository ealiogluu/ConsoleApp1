using BookStoreForms.BookStore;
using BookStoreForms.UserForms;
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLogIn employeeLogIn = new EmployeeLogIn();
            employeeLogIn.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            //main.lblAccount.Text =
            main.ShowDialog();
        }


        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    FormSignUp formSignUp = new FormSignUp();   
        //    formSignUp.ShowDialog();
        //}
    }
}
