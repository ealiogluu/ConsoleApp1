using System;
using System.Collections.Generic;

namespace BookStore
{
    internal class Basket
    {
        public static List<Book> books = new List<Book>(); 
        public void AddNewBook()
        {
            Console.WriteLine("add book to basket that you want. ");
            string name = Console.ReadLine();

            foreach (Book book in BookStore.Books)
                if (book.Name == name)  books.Add(book);
        }
        public double GetTotalPrice()
        {
            double totalPrice = 0;

            foreach (Book book in books)
                totalPrice += book.Price;

            return totalPrice;
        }
        public void DisplayBasketInfo()
        {
            Console.WriteLine("\t\tBASKET");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Book Name\t|\tBook Price");
            Console.WriteLine("------------------------------------------");


            foreach (var b in books)
                Console.WriteLine(b.Name + "\t|\t" + b.Price);

            Console.WriteLine("------------------------------------------");
            double t = GetTotalPrice();
            Console.WriteLine("\tTotal Price: " + t);
            Console.WriteLine();

        }
    }
}