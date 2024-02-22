using System;

namespace BookStore.BookFilters
{
    internal class BookPriceFilter100_200: IBookPriceFilter
    {
        public void Filter()
        {
            foreach (Book book in BookStore.Books)
            {
                if (book.Price > 100 && book.Price < 200)
                {
                    Console.WriteLine(book.Name + "\t\t" + book.Category + "\t\t" + book.Price);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}
