using System;
using System.Security.Cryptography.X509Certificates;

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
        public int CategoryId { get; set; }
        public string Category { get; set; }    
        public double Price { get; set; }
        public string Publisher { get; set; }
        public Book() { }
        public Book(string name, int pageCount, string writer, string category, double price, int categoryId, string publisher)
        {
            Name = name;
            PageCount = pageCount;
            Writer = writer; 
            Category = category;
            Price = price;
            CategoryId = categoryId;
            Publisher = publisher;
        }
    }
}