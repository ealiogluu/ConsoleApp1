using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.NewBookStore.Model
{
    public class Book
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public double Price { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string author, double price, int pageCount)
        {
            Name = name;
            Author = author;
            Price = price;
            PageCount = pageCount;
        }
    }
}
