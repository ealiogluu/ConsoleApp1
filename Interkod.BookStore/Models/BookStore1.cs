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

            //Book book1 = new Book("Suç", "Ahmet", 56, 67.90);
            //Book book2 = new Book("yasa", "mehmet", 90, 89.90);
            //Book book3 = new Book("yasak", "hamdi", 100, 110);
            //Book book4 = new Book("Kezzap", "ayşe", 56, 23);

            //Books.Add(book1);
            //Books.Add(book2);
            //Books.Add(book3);
            //Books.Add(book4);
        }
    }
}
