using BookStore.BookFilters;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStore
{
    internal class Customer
    {
        public Customer()
        {
            basket = new Basket();
            //customers = new List<Customer>();
        }

        public Basket basket;
        public string Name { get; set; }
        public string Adress { get; set; }
        public double PhoneNumber { get; set; }
        public double Password { get; set; }

        public Customer(string nameSurname, string adress, double phoneNumber, double password)
        {
            Name = nameSurname;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Password = password;
            basket = new Basket();
        }
        public void DisplayMainMenu()
        {
            Console.WriteLine("\nSelect process that you want to do:");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1- Display all books and their prices.");
            Console.WriteLine("2- Display all publishers.");
            Console.WriteLine("3- Add to basket books.");
            Console.WriteLine("4- Remove from basket books.");
            Console.WriteLine("5- Display basket.");
            Console.WriteLine("6- Check Out the my order.");
            Console.WriteLine("7- Display my own informations.");
            Console.WriteLine("8- Filter genre of books.");
            Console.WriteLine("9- Filter publishers.");
            Console.WriteLine("10- Filter price.\n");

            string choose = Console.ReadLine();
            Console.WriteLine();

            if (choose == "1")
            {
                DisplayAllBooks();
            }
            else if (choose == "2")
            {
                DisplayAllPublishers();
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
                basket.DisplayBasketInfo();
            }
            else if (choose == "6")
            {
                CheckOut();
            }
            else if (choose == "7")
            {
                DisplayOwnInfo();
            }
            else if (choose == "8")
            {
                FilterGenres();
            }
            else if (choose == "9")
            {
                FilterPublisher();
            }
            else if (choose == "10")
            {
                FilterPrice();
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
                Console.WriteLine(book.Name + "\t\t" + book.PageCount + "\t\t" + book.Price);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            FilterGenres();
        }
        public void Remove()
        {
            Console.WriteLine("Enter book name that you want to remove from your basket.");
            string secim = Console.ReadLine();

            //Basket.books.FirstOrDefault(book => book.Name == secim);

            foreach (Book book in Basket.books)
            {
                if (book.Name == secim)
                {
                    Basket.books.Remove(book);
                    Console.WriteLine(book.Name + " is removed.\n");
                    return;
                }
            }

        }
        public void DisplayOwnInfo()
        {
            Console.WriteLine("***MY INFORMATIONS***\n");
            Console.WriteLine("Name and Surname: " + Name);
            Console.WriteLine("Phone Number: " + PhoneNumber);
            Console.WriteLine("Adress: " + Adress);
            Console.WriteLine();
        }
        public void CheckOut()
        {
            basket.DisplayBasketInfo();

            Console.WriteLine("Enter the 1 for check out or 2 for return.");
            int choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (choose == 1) Console.WriteLine("Your order is checked out.\n");
            else DisplayMainMenu();

        }
        public void FilterGenres()
        {
            Console.WriteLine("Which types of books do you want?");
            Console.WriteLine("1-Novels.");
            Console.WriteLine("2-Poems.");
            Console.WriteLine("3-Stories.");

            int choose = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t\tAll Books That You FiLtered");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Book Name   |   Category   |   Page Count");
            Console.WriteLine("------------------------------------------------\n");

            if (choose == 1)
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
            else if (choose == 2)
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
            else if (choose == 3)
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
        public void FilterPrice()
        {
            int choose = DisplayFilterPriceHeaders();

            DoFilterByChoose(choose);
        }
        private static int DisplayFilterPriceHeaders()
        {
            Console.WriteLine("Which interval of price are you looking at?");
            Console.WriteLine("1- 0-100");
            Console.WriteLine("2- 100-200");
            Console.WriteLine("3- 200-500");
            Console.WriteLine("4- 500++");

            int choose = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t\tAll Books That You FiLtered");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Book Name   |   Category   |   Price");
            Console.WriteLine("------------------------------------------------\n");
            return choose;
        }
        private void DoFilterByChoose(int choose)
        {
            IBookFilter filter = null;

            if (choose == 1)      filter = new BookFilter0_100();
            else if (choose == 2) filter = new BookFilter100_200();
            else if (choose == 3) filter = new BookFilter200_500();
            else if (choose == 4) filter = new BookFilter500Plus();
            else if (choose == 5) filter = new BookFilter1000Plus();

            filter.Filter();
        }
        public void FilterPublisher()
        {
            Console.WriteLine("Which publisher of books do you search?");
            string choose = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("   All Books That You FiLtered to Publisher");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Publisher  |   Book Name   |   Writer");
            Console.WriteLine("------------------------------------------------");

            foreach (Book book in BookStore.Books)
            {
                if (choose == book.Publisher)
                {
                    Console.WriteLine(book.Publisher + " | " + book.Name + " | " + book.Writer );
                }
            }
            Console.WriteLine("------------------------------------------------\n");
        }
        public void DisplayAllPublishers()
        {
            Console.WriteLine("\tAll Publishers");
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("Publisher Name");
            Console.WriteLine("-------------------------------");

            foreach (Publisher publisher in BookStore.Publishers)
            {
                Console.WriteLine(publisher.PublishName);
            }
            Console.WriteLine("-------------------------------\n");
        }
    }
}

