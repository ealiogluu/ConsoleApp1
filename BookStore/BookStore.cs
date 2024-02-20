using System;
using System.CodeDom;
using System.Collections.Generic;

namespace BookStore
{
    /// <summary>
    /// kitapçı
    /// </summary>
    internal class BookStore
    {
        public List<Customer> Customers = new List<Customer>();
        public static List<Book> Books = new List<Book>();
        public BookStore()
        {
            Book book1 = new Book("Yaban", 123, "Yakup Kadri Karaosmanoğlu", "Novel", 123, 1);
            Book book2 = new Book("Suç ve Ceza", 650, "Dostoyevski", "Novel", 250, 1);
            Book book3 = new Book("İçimizdeki Şeytan", 67, "Sabahattin Ali", "Novel", 45, 1);
            Book book4 = new Book("Şiir'k",23,"Furkan Dowan","Poem",77,2);
            Book book5 = new Book("Tek Şiir",56,"Halil Şahan","Poem",112,2);
            Book book6 = new Book("Şiir Çıplak",90,"Veysel çolak","Poem",120,2);
            Book book7 = new Book("Uzun Hikaye", 25, "Mustafa Kutlu", "Story", 34, 3);
            Book book8 = new Book("Hikaye", 67, "Halit Ziya Uşaklıgil", "Story", 70, 3);
            Book book9 = new Book("Hikayeden Hatıraya", 34, "hüseyin Hüsnü Yazıcı", "Story", 50, 3);

            //Books.Add(book1);
            //Books.Add(book2);
            //Books.Add(book3);
            //Books.Add(book4);
            //Books.Add(book5);

            Customer customer1 = new Customer("Emine Nur Alioğlu", "Barıs mah.", 5337161659, 1234);
            Customer customer2 = new Customer("Ayse Kaya", "baris", 5306639944, 567);
            Customer customer3 = new Customer("emine kaya", "guzelyali", 5306630375, 3456);
            Customer customer4 = new Customer("esma alioğlu", "baris", 5339630561, 897);
            Customer customer5 = new Customer("sude akar", "gunesli", 6305785632, 4567);

            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Add(customer4);
            Customers.Add(customer5);
        }
        public void DisplayMainMenu()
        {

            Console.WriteLine("***Welcome to BookStore***\n");
            Console.WriteLine("Please select that you want to do.\n");
            Console.WriteLine("1- Add new book to system.");
            Console.WriteLine("2 Remove book.");
            Console.WriteLine("3- Search book.");
            Console.WriteLine("4- Display all books.");
            Console.WriteLine("5- Display all customers.");
            Console.WriteLine("6- Add new customer.");
            Console.WriteLine("7- Remove customer.");
            Console.WriteLine("8- Search book.\n");


            string choose = Console.ReadLine();
            Console.WriteLine();

            if (choose == "1")
            {
                AddNewBook();
            }
            else if (choose == "2")
            {
                RemoveBook();
            }
            else if (choose == "3")
            {
                SearchBook();
            }
            else if (choose == "4")
            {
                DisplayAllBooks();
            }
            else if (choose == "5")
            {
                DisplayAllCustomers();
            }
            else if (choose == "6")
            {
                AddNewCustomer();
            }
            else if (choose == "7")
            {
                RemoveCustomer();
            }
            else if (choose == "8")
            {
                SearchBook();
            }
            DisplayMainMenu();
        }
        public void LogInToSystem()
        {
            Console.WriteLine("User menu: 1");
            Console.WriteLine("Employee menu: 2");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                UserProcess();
            }
            else if (secim == 2)
            {
                EmployeeLogIn();
            }
        }
        public void UserLogIn()
        {
            Console.Write("name and surname: ");
            string chooseName = Console.ReadLine();
            Console.WriteLine("Password: ");
            int choosePassword = Convert.ToInt32(Console.ReadLine());

            foreach (Customer customer in Customers)
            {
                if (customer.Name == chooseName && customer.Password == choosePassword)
                {
                    customer.DisplayMainMenu();
                    return;
                }
            }
            Console.WriteLine("Password is wrong!Please try again.\n");
            UserLogIn();
        }
        public void EmployeeLogIn()
        {
            Console.Write("System Password: ");
            double password = Convert.ToDouble(Console.ReadLine());

            if (password == 1234567) DisplayMainMenu();
            else Console.WriteLine("Password is wrong! Please try again.\n");
            EmployeeLogIn();
        }
        public void UserProcess()
        {
            Console.WriteLine("1- Sign in.");
            Console.WriteLine("2- Log in.");
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                SignIn();
            }
            else if (choose == 2)
            {
                UserLogIn();
            }

        }
        public void AddNewBook()
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
        public void AddNewCustomer()
        {
            Customer customer = new Customer();

            Console.WriteLine("Enter your informations.\n ");

            Console.Write("Name and Surname:  ");
            customer.Name = Console.ReadLine();

            Console.Write("Adress: ");
            customer.Adress = Console.ReadLine();

            Console.Write("Phone Number: ");
            customer.PhoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Password: ");
            customer.Password = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Customers.Add(customer);
        }
        public void RemoveBook()
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
        public void RemoveCustomer()
        {
            Console.WriteLine("enter the name and surname of customer.");
            string choose = Console.ReadLine();

            foreach (Customer customer in Customers)
            {
                if (customer.Name == choose)
                {
                    Customers.Remove(customer);
                    return;
                }
            }
            Console.WriteLine("Customer is removed.");
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
            Console.WriteLine("***CUSTOMER INFORMATIONS***\n");
            foreach (var customer in Customers)
            {
                Console.WriteLine("Customer Name and Surname: " + customer.Name);
                Console.WriteLine("Customer Phone Number: " + customer.PhoneNumber);
                Console.WriteLine("Customer Adress: " + customer.Adress);
                Console.WriteLine();
            }
        }
        public void FilterBooks()
        {
            Console.WriteLine("Which types of books do you want?");
            Console.WriteLine("1-Novels.");
            Console.WriteLine("2-Poems.");
            Console.WriteLine("3-Stories.");

            int choose = Convert.ToInt32(Console.ReadLine());

            //foreach (var book in Books)
            //{
            //    if (choose == 1 )
            //    {
            //        cw
            //    }
            //}
        }
        public void SignIn()
        {
            Customer customer = new Customer();

            Console.WriteLine("Enter your informations.\n ");

            Console.Write("Name and Surname:  ");
            customer.Name = Console.ReadLine();

            Console.Write("Adress: ");
            customer.Adress = Console.ReadLine();

            Console.Write("Phone Number: ");
            customer.PhoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Password: ");
            customer.Password = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Customers.Add(customer);

            Console.WriteLine("Please log in.");
            UserLogIn();
        }
    }
}