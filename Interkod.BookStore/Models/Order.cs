using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class Order
    {
        public static List<Order> Orders = new List<Order>();
        public int OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public Basket Basket { get; set; }

        public Order()
        {
            Basket = new Basket();
            Customer = new Customer();
        }

        public Order(int orderNumber)
        {
            OrderNumber = orderNumber;
            Basket = new Basket();
        }
    }
}
