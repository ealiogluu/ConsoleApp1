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
        public int Password { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public Customer(string userName, int password, string name, string adress, long phoneNumber )
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
