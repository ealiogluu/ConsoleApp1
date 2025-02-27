﻿using Interkod.BookStore.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Interkod.BookStore.ViewModel
{
    public class LoginViewModel
    {
        MainViewModel viewModel = new MainViewModel();
        LogInPage LogInPage { get; set; } = new LogInPage();
        public string Username { get; set; }
        public string Password { get; set; }

        public RelayCommand LogInCommand => new RelayCommand(execute => { LogIn(Username, Password); }, canExecute => { return true; });

        public void LogIn(string userName, string password)
        {
            foreach (var customer in viewModel.BookStore.Customers)
            {
                if (userName.Equals(customer.UserName) && password == customer.Password)
                {
                    MessageBox.Show("Log in successful.");
                    return;
                }
                else MessageBox.Show("Please try again.");

            }
        }
    }
}
