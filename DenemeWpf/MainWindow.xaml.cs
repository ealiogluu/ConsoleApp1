﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DenemeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();


        }

        private void toggleButon_Click(object sender, RoutedEventArgs e)
        {
            if (running) 
            {
                lbstatus.Text = "Stopped.";
                toggleButon.Content = "Run";
            }
            else
            {
                lbstatus.Text = "Runned";
                toggleButon.Content = "Stop";
            }
            running =! running;

        }
    }
}