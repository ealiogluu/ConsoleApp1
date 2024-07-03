using Interkod.BookStore.Models;
using Interkod.BookStore.ViewModel;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interkod.BookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindoViewModel VM { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            VM = new MainWindoViewModel();
            DataContext = VM;
        }

    }
}