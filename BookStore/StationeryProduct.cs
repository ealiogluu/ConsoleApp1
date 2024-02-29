using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class StationeryProduct
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }

        public StationeryProduct(string productName, int productId)
        {
            ProductId = productId;
            ProductName = productName;
        }

    }
}
