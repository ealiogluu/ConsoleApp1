using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class OrderItem
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Book book, int quantity)
        {
            
            Book = book;
            Quantity = quantity;
             
        }
    }
}
