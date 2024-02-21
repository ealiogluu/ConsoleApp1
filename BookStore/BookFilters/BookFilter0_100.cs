using System;

namespace BookStore.BookFilters
{
    internal class BookFilter0_100 : IBookFilter
    {
        public void Filter()
        {
            foreach (Book book in BookStore.Books)
            {
                if (book.Price > 0 && book.Price < 100)
                {
                    Console.WriteLine(book.Name + "\t\t" + book.Category + "\t\t" + book.Price);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}