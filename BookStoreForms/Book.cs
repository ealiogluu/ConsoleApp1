using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreForms
{
    internal class Book
    {
        public string Name { get; set; }
        public string Writer { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string writer, string publisher, int pageCount)
        {
            Name = name;
            Writer = writer;
            Publisher = publisher;
            PageCount = pageCount;
        }
    }
}
