using System;

namespace BookStore
{
    internal class Program
    {
        static void Main()
        {
            BookStore bookStore = new BookStore();
            bookStore.LogInToSystem();

            Console.ReadLine();
        }
    }
}