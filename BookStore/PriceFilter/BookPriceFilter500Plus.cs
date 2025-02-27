﻿using System;

namespace BookStore.BookFilters
{
    internal class BookPriceFilter500Plus: IBookPriceFilter
    {
        public void Filter()
        {
            foreach (Book book in BookStore.Books)
            {
                if (book.Price > 500)
                {
                    Console.WriteLine(book.Name + "\t\t" + book.Category + "\t\t" + book.Price);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}
