namespace BookStore.BookFilters
{
    internal class BookFilterFactory
    {
        public static IBookFilter GetBookFilter(int choose)
        {
            IBookFilter filter = null;

            if (choose == 1)      filter = new BookFilter0_100();
            else if (choose == 2) filter = new BookFilter100_200();
            else if (choose == 3) filter = new BookFilter200_500();
            else if (choose == 4) filter = new BookFilter500Plus();
            else if (choose == 5) filter = new BookFilter1000Plus();
            
            return filter;
        }
    }
}