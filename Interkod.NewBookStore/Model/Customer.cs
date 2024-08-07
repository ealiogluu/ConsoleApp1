using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.NewBookStore.Model
{
    public class Customer
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string UserName { get; set; }
        public string? Email { get; set; }
        public int Password { get; set; }
        public Customer() { }
        public Customer(string name, string surname, string userName, string email, int password)
        {
            Name = name;
            Surname = surname;
            UserName = userName;
            Email = email;
            Password = password;
        }
    }
}
