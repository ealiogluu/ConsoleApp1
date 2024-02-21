using System;

namespace BookStore.BookFilters
{
    internal class BookFilter200_500 : IBookFilter
    {
        public void Filter()
        {
            foreach (Book book in BookStore.Books)
            {
                if (book.Price > 200 && book.Price < 500)
                {
                    Console.WriteLine(book.Name + "\t\t" + book.Category + "\t\t" + book.Price);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}
