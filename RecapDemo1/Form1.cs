﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];

            int Top = 0;
            int left = 0;

            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++)
                {

                    buttons[i, j] = new Button();
                    buttons[i,j].Width = 50;
                    buttons[i,j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = Top;
                    left += 50;
                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.White;
                    else buttons[i, j].BackColor = Color.Black;
                
                    this.Controls.Add(buttons[i,j]);
                }
                left = 0;
                Top += 50;
   
            }

           
        }
    }
}
