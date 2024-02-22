using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Order
    {
        public Basket Basket { get; set; }
        public int OrderNumber { get; set; }

        public Order()
        {
            Basket = new Basket();
        }
        public Order(int orderNumber)
        {
            Basket = new Basket();
            OrderNumber = orderNumber;
        }
        public void OrderFollow()
        {

        }
    }
}
