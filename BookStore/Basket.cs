using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStore
{
    internal class Basket
    {
        public static List<Book> books = new List<Book>();  
        public void Add()
        {
            Console.WriteLine("add book to basket that you want. ");
            string name = Console.ReadLine();

            Book book = BookStore.Books.FirstOrDefault(b => b.Name == name);
            books.Add(book);
        }



        //public void Remove(string bookName)
        //{
        //    bool isRemoved = books.Remove(books.First(b => b.Name == bookName));
        //    if (isRemoved) Console.WriteLine("Removed");

        //    //foreach (var a in books)
        //    //{
        //    //    if(a.Name == bookName)
        //    //    {
        //    //        books.Remove(a);
        //    //        Console.WriteLine(bookName+" removed.");
        //    //    }
        //    //}
        //}

        public void SearchBooks()
        {
            Console.WriteLine("Search book that you want.\n");
            string name = Console.ReadLine();

            foreach (var a in books)
            {
                if (a.Name == name)
                {
                    Console.WriteLine("\n" + name + " is available in your basket!");
                    return;
                }
            }

            Console.WriteLine("\n" + name + " is not available in your basket!\n");
        }

        public double GetTotalPrice()
        {
            double totalPrice = 0;
            foreach (Book book in books)
            {
                totalPrice += book.Price;
            }
            return totalPrice;
        }

        public void DisplayBasketInfo()
        {
            Console.WriteLine("\t\tBASKET");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Book Name\t|\tBook Price");
            Console.WriteLine("------------------------------------------");


            foreach (var b in books)
            {
                Console.WriteLine(b.Name + "\t|\t" + b.Price);
            }

            Console.WriteLine("------------------------------------------");
            double t = GetTotalPrice();
            Console.WriteLine("\tTotal Price: " + t);
        }
    }
}