using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyClass
    {

    }

  class Customer
    {
       
        string _firstName;
        public string FirstName
        {
            get { return "Mrs." + _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }
        public string City {  get; set; }       
        public int Id { get; set; }

        
    }

}
