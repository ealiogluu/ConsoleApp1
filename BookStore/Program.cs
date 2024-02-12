using System;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BookStore bookStore = new BookStore();
            Customer customer= new Customer();

            customer.DisplayMainMenu();

            Console.ReadLine();
        }
    }
}