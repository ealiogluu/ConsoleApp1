using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreForms
{
    internal class Client
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public Client(){  }
        public Client(string name, string userName, string adress, string phoneNumber, string password)
        {
            Name = name;
            UserName = userName;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
