using System.Collections.Generic;

namespace BookStoreForms
{
    class BookStore
    {
        public static List<Book> Books = new List<Book>();      

        public static List<Client> Clients = new List<Client>();


        static BookStore()
        {
            Book book1 = new Book("İnsan Ne ile Yaşar?", "Tolstoy", "Can Yayınları", 67);
            Books.Add(book1);

            Client client1 = new Client("Azra", "azrakiraz " , "Barış", 768456, "123");
            Client client2 = new Client("Barış","barisdemir ", "Gültepe", 346, "123");
            Clients.Add(client1);
            Clients.Add(client2);
        }

    }
}
