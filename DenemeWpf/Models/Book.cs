using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeWpf.Models
{
    internal class Book
    {
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public string Name { get; set; }
        public string Author { get; set; }

    }
}
