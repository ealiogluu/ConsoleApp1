using DenemeWpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenemeWpf.ViewModels
{
    internal class MainViewModel
    {
        public List<Book> BookNames { get; set; } = 
            [
                new Book("ada","necip"),
                new Book("ada","necip"),
                new Book("ada","necip"),
                new Book("ada","necip"),
                new Book("ada","necip"),
                new Book("ada","necip"),
                new Book("ada","necip"),
                new Book("ada","necip")
            ];
        
    }
}
