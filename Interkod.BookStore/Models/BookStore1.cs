using System.Collections.ObjectModel;

namespace Interkod.BookStore.Models;

public class BookStore1
{
    // Registrated customers
    public List<Customer> Customers = [];

    // All books on the system
    public ObservableCollection<Book> Books { get; set; } = [];

    public BookStore1() { }
    public BookStore1(List<Customer> customers, List<Book> books)
    {
        Customers = customers;
        Books     = new ObservableCollection<Book>(books);
    }
}