using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForsComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Trabzon");
            comboBox1.Items.Add("Giresun");
            comboBox1.Items.Add("Hatay");
            comboBox1.Items.Add("Mersin");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string choose = comboBox1.SelectedItem.ToString();
            label1.Text = $"You selected {choose}. ";
        }

    }
}
