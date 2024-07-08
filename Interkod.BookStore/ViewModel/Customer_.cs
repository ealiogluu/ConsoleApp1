using Interkod.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Interkod.BookStore.ViewModel
{
    class Customer_
    {
        public BookStore1 BookStore1 { get; set; } = new BookStore1();  
        public void LogIn(string userName, int password)
        {
            foreach (var customer in BookStore1.Customers)
            {
                if (userName.Equals(customer.UserName))
                {
                    if (password.Equals(customer.Password))
                        MessageBox.Show("Log in successful.");

                    else MessageBox.Show("Please try again.");

                }
                else MessageBox.Show("Please try again.");
            }
        }

        public void SignUp(string name, string adress, string userName, long phoneNumber, int password)
        {
            var customer = new Customer();

            customer.Name = name;
            customer.Address = adress;
            customer.UserName = userName;
            customer.PhoneNumber = phoneNumber;
            customer.Password = password;

            BookStore1.Customers.Add(customer);

            MessageBox.Show("Registrated is successful! Welcome :)");
        }

        public void SearchBook(string name)
        {
            foreach (var book in BookStore1.Books)
            {
                if (book.Name.Equals(name))
                {
                    MessageBox.Show("The book that you are looking at available. Piece: " + book.BookCount);
                    return;
                }
            }
            MessageBox.Show("The book is not available.");
        }
    }
}
