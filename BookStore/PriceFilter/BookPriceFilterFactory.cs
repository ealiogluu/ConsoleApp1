namespace BookStore.BookFilters
{
    internal class BookPriceFilterFactory
    {
        public static IBookPriceFilter GetBookFilter(int choose)
        {
            IBookPriceFilter filter = null;

            if (choose == 1)      filter = new BookPriceFilter0_100();
            else if (choose == 2) filter = new BookPriceFilter100_200();
            else if (choose == 3) filter = new BookPriceFilter200_500();
            else if (choose == 4) filter = new BookPriceFilter500Plus();
            else if (choose == 5) filter = new BookPriceFilter1000Plus();
            
            return filter;
        }
    }
}