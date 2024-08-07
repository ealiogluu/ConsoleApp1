using Interkod.NewBookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.NewBookStore.ViewModel
{
    public class BookStoreViewModel
    {
        public List<Book> Books { get; set; } 
        public List<Customer> Customers { get; set; }

        public BookStoreViewModel()
        {
            Books = new List<Book>();
            Customers = new List<Customer>();

            Book book1 = new Book("Bilinçli Aile Olmak", "Nevzat Tarhan", 129.90, 224);
            Book book2 = new Book("Paranın Tarihi", "Philip Coggan", 357.50, 500);

            Books.Add(book1);
            Books.Add(book2);

            Customer customer1 = new Customer("Emine Nur", "Alioğlu", "eminealioglu", "emine@gmail.com", 123);
            Customer customer2 = new Customer("Seda", "Kayıkcı", "sedakayıkcı", "seda@gmail.com", 123);

            Customers.Add(customer1);
            Customers.Add(customer2);
        }

    }
}
