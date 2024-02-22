using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.PriceFilter
{
    public interface IGenresFilter
    {
        void FilterGenre(int choose);
    }
}
