using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class OrderItem
    {
        public Order Order { get; set; }
        public string  Book { get; set; }
        public int Quantity { get; set; }

        public OrderItem(string book, int quantity)
        {
            Order = new Order();
            Book = book;
            Quantity = quantity;
             
        }
    }
}
