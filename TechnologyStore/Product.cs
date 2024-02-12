using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyStore
{
    internal class Product
    {
        public string Brand { get; set; }
        public string Category { get; set; }

        public Product(string category, string brand)
        {
            
            this.Brand = brand;
            this.Category = category;

        }


        
    }
}
