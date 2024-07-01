using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class Order
    {
        public static List<OrderItem> OrderItems = new List<OrderItem>();
        public int OrderNumber { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            Customer = new Customer();
        }

        public void AddOrderItem (OrderItem orderNumber)
        {
           
        }

        public void AddOrderBook()
        {
            Console.WriteLine("Add book.");

            string name = Console.ReadLine();

            foreach (var book in BookStore.Books)
            {
                if (book.Name == name)
                {
                    BookStore.Orders.Add(book);
                }

            }
        }


        public void RemoveOrderBook()
        {
            Console.WriteLine("please enter the name of the book correctly.");

            string name = Console.ReadLine();

            foreach(var book in BookStore.Orders)
            {
                if (book.Name == name) BookStore.Orders.Remove(book);
            }
         

        }
    }
}
