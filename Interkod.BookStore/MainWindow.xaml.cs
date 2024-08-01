using Interkod.BookStore.Models;
using Interkod.BookStore.ViewModel;
using System.Windows;

namespace Interkod.BookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainViewModel VM { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            VM = new MainViewModel();
            DataContext = VM;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VM.AddItemToBasket(VM.SelectedBook, 2);
        }


        private void Button_Click_Reduce(object sender, RoutedEventArgs e)
        {
            VM.ReduceOrderItem(VM.SelectedBasketItem);
        }

        private void Button_Click_LogIn(object sender, RoutedEventArgs e)
        {
           LogInPage logInPage = new LogInPage();
            this.Visibility = Visibility.Visible; 
            logInPage.Show();
        }
    } }