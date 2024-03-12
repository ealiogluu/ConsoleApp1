using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add();
        }

        private void EklemeButonu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Isim.Text.ToString());
            Isim.Text = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIndex.Text= listBox1.SelectedIndex.ToString();
            labelIsim.Text= listBox1.SelectedIndex.ToString();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string isim = checkBox1.Text.ToString();
                listBox1.Items.Add(isim);
            }
            else
            {
                string isim = checkBox1.Text.ToString();
                listBox1.Items.Remove(isim);
            }
        }

    }
}
