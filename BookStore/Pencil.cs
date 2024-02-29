using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class Pencil
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public Pencil(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }
    }
}
