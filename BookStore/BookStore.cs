using System;
using System.Collections.Generic;

namespace BookStore
{
    /// <summary>
    /// 
    /// </summary>
    internal class BookStore
    {
        public List<Customer> Customers = new List<Customer>();
        public static List<Book> Books = new List<Book>();

        public void DisplayMainMenu()
        {
            Console.WriteLine("***Welcome to BookStore***\n");
            Console.WriteLine("Please select that you want to do.");
            Console.WriteLine("1- Add new book to system.");
            Console.WriteLine("2 Remove book.");
            Console.WriteLine("3- Search book.");
            Console.WriteLine("4- Display all books.");
            Console.WriteLine("5- Display all customers.\n");

            string choose = Console.ReadLine();
            Console.WriteLine();

            if (choose == "1")
            {
                Add();
            }
            else if (choose == "2")
            {
                Remove();
            }
            else if (choose == "3")
            {
                SearchBook();
            }
            else if (choose == "4")
            {
                DisplayAllBooks();
            }
            else if(choose == "5")
            {
                DisplayAllCustomers();
            }

            DisplayMainMenu();
        }
        public void AddNewCustomer() 
        {
            Customer customer = new Customer();

            Console.WriteLine("Enter your informations.\n ");

            Console.Write("Name and Surname:  ");
            customer.NameSurname = Console.ReadLine();

            Console.Write("Adress: ");
            customer.Adress = Console.ReadLine();

            Console.Write("Phone Number: ");
            customer.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Customers.Add(customer);
        }
        public void Add()
        {
            var book = new Book();

            Console.WriteLine("Enter a new book.");

            Console.Write("Book Name: ");
            book.Name = Console.ReadLine();

            Console.Write("Writer: ");
            book.Writer = Console.ReadLine();

            Console.Write("Price: ");
            book.Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Page Count: ");
            book.PageCount = Convert.ToInt32(Console.ReadLine());

            Books.Add(book);
            Console.WriteLine();
        }
        public void Remove()
        {
            Console.WriteLine("Enter the book that you want to remove.");
            string name = Console.ReadLine();
            Console.WriteLine();

            foreach (Book book in Books)
            {
                if (name == book.Name)
                {
                    Books.Remove(book);
                    Console.WriteLine("Book is removed.\n");
                    return;
                }
            }

            Console.WriteLine("Unsuccessful," + name + " is not available.");
        }
        public void SearchBook()
        {
            Console.WriteLine("Search book that you want.\n");
            string name = Console.ReadLine();
            Console.WriteLine();

            foreach (Book book in Books)
            {
                if (name == book.Name)
                {
                    Console.WriteLine(name + " is available.\n");
                    return;
                }
            }
            Console.WriteLine(name + " is not available.\n");
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine("\t\tAll Books");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Book Name   |   Page Count   |   Book Price");
            Console.WriteLine("------------------------------------------------");

            foreach (Book book in Books)
                Console.WriteLine(book.Name + "\t\t" + book.PageCount + "\t\t" + book.Price + "\n");
        }
        public void DisplayAllCustomers()
        {
            foreach (var customer in Customers )
            {
                Console.WriteLine("***CUSTOMER INFORMATIONS***\n");
                Console.WriteLine("Customer Name and Surname: " + customer.NameSurname);
                Console.WriteLine("Customer Phone Number: " + customer.PhoneNumber);
                Console.WriteLine("Customer Adress: " + customer.Adress);
                Console.WriteLine();
            }
        }





    }
}