using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Phone"},
                new Category{CategoryId=2,CategoryName="Computer"}
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductName="Apple",ProudctId=1,CategoryId=1,UnitPrice=10000,UNitsInStock=0,QuantitiyPerUnit="8Gb Ram"},
                new Product{ProductName="Hp",   ProudctId=2,CategoryId=2,UnitPrice=8000,UNitsInStock=4,QuantitiyPerUnit="32Gb Ram"},
                new Product{ProductName="Xiaomi",ProudctId=3,CategoryId=1,UnitPrice=5000,UNitsInStock=12,QuantitiyPerUnit="8Gb Ram"},
                new Product{ProductName="Samsung",ProudctId=4,CategoryId=1,UnitPrice=9000,UNitsInStock=7,QuantitiyPerUnit="4Gb Ram"},
                new Product{ProductName="LG",ProudctId=5,CategoryId=2,UnitPrice=12000,UNitsInStock=2,QuantitiyPerUnit="64Gb Ram"},
                new Product{ProductName="Apple",ProudctId=6,CategoryId=2,UnitPrice=20000,UNitsInStock=1,QuantitiyPerUnit="32Gb Ram"},
        };


        }

             

    

        

        


        class Product
        {
            public int ProudctId { get; set; }
            public string ProductName { get; set; }
            public int CategoryId { get; set; }
            public int UnitPrice { get; set; }

            public int UNitsInStock { get; set; }
            public string QuantitiyPerUnit { get; set; }

        }
        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
