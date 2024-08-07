using Interkod.NewBookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Interkod.NewBookStore.ViewModel
{
    class CustomerViewModel
    {
        public BookStoreViewModel MainVM { get; set; } = new BookStoreViewModel();
        public void LogIn(string userName, int password)
        {
            foreach (var customer in MainVM.Customers)
            {
                if (customer.UserName.Equals(userName) && customer.Password.Equals(password))
                {
                    MessageBox.Show("Welcome!");
                    return;
                }
            }
            MessageBox.Show("Try again, username or password is wrong.");
        }

        public void SignUp(string name, string surname, string userName, string email, int password)
        {
            var customer = new Customer();
            customer.Name = name;
            customer.Surname = surname;
            customer.UserName = userName;
            customer.Email = email;
            customer.Password = password;

            MainVM.Customers.Add(customer);

            MessageBox.Show("Registration is successful.");
        }



    }
}
