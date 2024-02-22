using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.PriceFilter
{
    internal class GenresFilterStories : IGenresFilter
    {
        public void FilterGenre(int choose)
        {
            foreach (Book book in BookStore.Books)
            {
                if (book.CategoryId == choose)
                {
                    Console.WriteLine(book.Name + "\t\t" + book.Category + "\t\t" + book.PageCount);
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                }
            }
            return;
        }
    }
}
