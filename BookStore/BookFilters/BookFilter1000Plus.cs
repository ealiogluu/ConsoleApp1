﻿using System;

namespace BookStore.BookFilters
{
    internal class BookFilter1000Plus : IBookFilter
    {
        public void Filter()
        {
            foreach (Book book in BookStore.Books)
            {
                if (book.Price > 1000)
                {
                    Console.WriteLine(book.Name + "\t\t" + book.Category + "\t\t" + book.Price);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}
