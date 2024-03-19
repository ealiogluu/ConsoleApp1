using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreForms
{
    internal class BookStore
    {
        public static List<Book> Books = new List<Book>();
        public static List<Client> Clients = new List<Client>();  
        public BookStore()
        {
            Book book1 = new Book("İnsan Ne ile Yaşar?", "Tolstoy", "Can Yayınları", 67);
            Books.Add(book1);

            Client client1 = new Client("Azra", "Barış", 768456, "123");
            Client client2 = new Client("Barış", "Gültepe", 346, "123");
            Clients.Add(client1);
            Clients.Add(client2);
        }
    }
}
