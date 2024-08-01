using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interkod.BookStore.Models
{
    public class Customer
    {
        public string Name { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Customer(string userName, string password, string name, string adress, string phoneNumber )
        {
            UserName = userName;
            Password = password;
            Name = name;
            Address = adress;
            PhoneNumber = phoneNumber;
                
        }
        public Customer() { }
    }
}
