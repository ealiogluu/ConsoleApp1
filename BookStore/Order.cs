using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Order
    {
        public double OrderNumber { get; set; }

        public Order(double orderNumber) 
        { 
            OrderNumber = orderNumber;
        }
        public void OrderFollow()
        {


        }
    }
}
