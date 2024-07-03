using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    public class BookStore1
    {
        // Registrated customers
        public List<Customer> Customers = new List<Customer>();

        // All books on the system
        public List<Book> Books = new List<Book>();

        public BookStore1(){}
        public BookStore1(List<Customer> customers, List<Book> books)
        {
            Customers = customers;
            Books = books;
        }
    }
}
