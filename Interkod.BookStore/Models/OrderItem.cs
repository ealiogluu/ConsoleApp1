using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public OrderItem() { }
        public OrderItem(Book book, int quantity, int id)
        {
            Book = book;
            Quantity = quantity;
            Id = id;
        }


    }
}
