using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreForms
{
    internal class BookStore
    {
        List<Book> books = new List<Book>();
        public BookStore()
        {
            Book book1 = new Book("İnsan Ne ile Yaşar?", "Tolstoy", "Can Yayınları", 67);
        }

    }
}
