using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class Basket
    {

        public static List<Basket> basket;
        public Customer Customer { get; set; }

        public Basket()
        {
            basket = new List<Basket>();    
            Customer = new Customer();
        }

    }
}
