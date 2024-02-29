using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore2
{
    internal class Book
    {
        public string Name { get; set; }
        public string Writer { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public string Price { get; set; }
        public string Publisher { get; set; }

        public Book(string name, string writer, string category, int pageCount, string price, string publisher)
        {
            Name = name;
            Writer = writer;
            Category = category;
            PageCount = pageCount;
            Price = price;
            Publisher = publisher;
        }

        //public Book() {}
    }
}
