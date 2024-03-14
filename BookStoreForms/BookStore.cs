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
            Clients.Add(client1);
        }

        public void UserLogIn()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Password: ");
            int password = Convert.ToInt32(Console.ReadLine());

        }

    }
}
