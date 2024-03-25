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
    public partial class EmployeeLogIn : Form
    {
        public EmployeeLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            string password = txtPassword.Text;

            if (password == "457")
            {
                EmployeeMenu employeeMenu = new EmployeeMenu();
                employeeMenu.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Incorrect Entry");
                EmployeeLogIn employeeLogIn = new EmployeeLogIn();
                employeeLogIn.ShowDialog(this);
            }
        }
    }
}
