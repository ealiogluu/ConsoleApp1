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
        public double Piece { get; set; } 
        public Pencil(string brand, string color, double piece)
        {
            Brand = brand;
            Color = color;
            Piece = piece;
        }
    }
}
