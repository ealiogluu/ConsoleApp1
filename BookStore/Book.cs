using System;

namespace BookStore
{
    /// <summary>
    /// Book Object
    /// </summary>
    internal class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
        public string Writer { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public Book() { }
        public Book(string name, int pageCount, string writer, string category, double price )
        {
            Name = name;
            PageCount = pageCount;
            Writer = writer;
            Category = category;
            Price = price;
                
        }
        public void DisplayInfo()
        {
            Console.WriteLine("***Book Info***");

            Console.WriteLine("Book Name\t: "+Name);
            Console.WriteLine("Papers\t\t: "+PageCount);
            Console.WriteLine("Writer\t\t: "+Writer);
            Console.WriteLine("Category\t: " + Category);
            Console.WriteLine("Price\t\t: " + Price);
        }



    }
}