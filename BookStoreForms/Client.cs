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
        public string Adress { get; set; }
        public double PhoneNumber { get; set; }
        public string Password { get; set; }

        public Client(string name, string adress, double phoneNumber, string password)
        {
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Password = password;
        }
    }
}
