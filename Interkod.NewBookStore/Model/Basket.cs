using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.NewBookStore.Model
{
    class Basket
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public Customer Customer { get; set; }
        public Basket()
        {
            Customer = new Customer();
        }
    }
}
