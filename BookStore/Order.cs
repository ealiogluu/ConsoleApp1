using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Order
    {
        public Customer Customer { get; set; }
        public Basket Basket { get; set; }
        public int OrderNumber { get; set; }

        public Order()
        {
            Customer = new Customer();
            Basket = new Basket();
        }
        public Order(int orderNumber)
        {
            Basket = new Basket();
            OrderNumber = orderNumber;
        }
    }
}
