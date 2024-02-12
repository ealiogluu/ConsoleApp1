using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStore
{
    internal class Customer
    {
        //public Customer()
        //{
        //    basket = new Basket();
        //    customers = new List<Customer>();
        //}

        public Basket basket;
        public string NameSurname { get; set; }
        public string Adress { get; set; }
        public double PhoneNumber { get; set; }

        //public Customer(string nameSurname, string adress, int phoneNumber)
        //{
        //    NameSurname = nameSurname;
        //    Adress = adress;
        //    PhoneNumber = phoneNumber;  
        //}

        public void DisplayMainMenu()
        {
            Console.WriteLine("Select process that you want to do\n*******");
            Console.WriteLine("1- Sign in.");
            Console.WriteLine("2- Display all books and their prices.");
            Console.WriteLine("3- Add to basket books.");
            Console.WriteLine("4- Remove from basket books.");
            Console.WriteLine("5- Display my own informations.\n");

            string choose = Console.ReadLine();
            Console.WriteLine();

            if (choose == "1")
            {
                
            }
            else if (choose == "2")
            {
                DisplayAllBooks();
            }
            else if (choose == "3")
            {
                basket.Add();
            }
            else if (choose == "4")
            {
                Remove();
            }
            else if (choose == "5")
            {
                DisplayOwnInfo();
            }

            DisplayMainMenu();
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("\t\tAll Books");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Book Name   |   Page Count   |   Book Price");
            Console.WriteLine("------------------------------------------------\n");

            foreach (Book book in BookStore.Books)
            {
                Console.WriteLine(book.Name + "\t\t" + book.PageCount + "\t\t" + book.Price + "\n");
            }
        }
        public void Remove()
        {
            Console.WriteLine("Enter book name that you want to remove from your basket.");
            string secim = Console.ReadLine();

            //Basket.books.FirstOrDefault(book => book.Name == secim);

            foreach (Book book in BookStore.Books)
            {
                if (book.Name == secim)
                {
                    BookStore.Books.Remove(book);
                    Console.WriteLine(book.Name + " is removed.");
                    return;
                }
            }

        }
        public void DisplayOwnInfo()
        {
            Console.WriteLine("***MY INFORMATIONS***\n");

            Console.WriteLine("Name and Surname: " + NameSurname);

            Console.WriteLine("Phone Number: " + PhoneNumber);

            Console.WriteLine("Adress: " + Adress);
            Console.WriteLine();
        }
    }
}
