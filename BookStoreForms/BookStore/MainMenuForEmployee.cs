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
    public partial class MainMenuForEmployee : Form
    {
        public MainMenuForEmployee()
        {
            InitializeComponent();
        }

        private void lblAddBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewBookSystem addNewBookSystem = new AddNewBookSystem();
            addNewBookSystem.ShowDialog();

            MainMenuForEmployee userProcess = new MainMenuForEmployee();    
            userProcess.ShowDialog();
        }
        private void lblNewClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new Client();
        }
    }
}
