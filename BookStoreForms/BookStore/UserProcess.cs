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
    public partial class UserProcess : Form
    {
        public UserProcess()
        {
            InitializeComponent();
        }

        private void lblAddBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewBookSystem addNewBookSystem = new AddNewBookSystem();
            addNewBookSystem.ShowDialog();

            UserProcess userProcess = new UserProcess();    
            userProcess.ShowDialog();
        }

        private void lblDisplayClients_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
