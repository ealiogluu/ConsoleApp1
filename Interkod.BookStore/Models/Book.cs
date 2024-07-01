using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }

       // public Book(){ }

        public Book(string name, string author, int pageCount, double price)
        {
            Name = name;    
            Author = author;
            PageCount = pageCount;
            Price = price;
        }
    }
}
