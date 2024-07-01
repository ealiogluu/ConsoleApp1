using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class BookStore
    {
        public static List<Book> Books = new List<Book>();

        public static List<Book> Orders = new List<Book>();   

        public BookStore()
        {
                Book book = new Book("adhef","jfof",34,45);

            Books.Add(book);
        }
    }
}
