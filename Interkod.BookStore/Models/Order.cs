using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    public class Order
    {
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public int OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public Order(){}

        public Order(List<OrderItem> orderItem, int orderNumber, Customer customer)
        {
            OrderItems = orderItem;
            OrderNumber = orderNumber;
            Customer = customer;
        }

    }
}
