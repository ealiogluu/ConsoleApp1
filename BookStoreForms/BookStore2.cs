using System.Collections.Generic;

namespace BookStoreForms
{
    public class BookStore2
    {
        public static List<Book> Books = new List<Book>();      

        public static List<Client> Clients = new List<Client>();


        static BookStore2()
        {
            Book book1 = new Book("İnsan Ne ile Yaşar?", "Tolstoy", "Can Yayınları","89");
            Books.Add(book1);

            Client client1 = new Client("Azra", "azrakiraz " , "Barış", "768456", "123");
            Client client2 = new Client("Barış","barisdemir ", "Gültepe", "123", "123");
            Clients.Add(client1);
            Clients.Add(client2);
        }

    }
}
