using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class Customer
    {
        public string Name { get; set; } 
        public int CustomerId { get; set; }

        public void AddBasketBook()
        {
            Console.WriteLine("Add book.");

            string name =  Console.ReadLine();

            foreach (var book in BookStore.Books)
            {
                

            }
        }
    }
}
