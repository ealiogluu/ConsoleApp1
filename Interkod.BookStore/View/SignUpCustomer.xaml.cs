using Interkod.BookStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Interkod.BookStore.View
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public MainViewModel SignUpView { get; set; }
        public Customer()
        {
            InitializeComponent();
        }
        private void Button_Click_SignUp(object sender, RoutedEventArgs e)
        {
            SignUpView.SignUp(txtbox_Name.Text, txtbox_Adress.Text, txtbox_UserName.Text, txtbox_PhoneNumber.Text, txtbox_Password.Text);
        }

    }
}
