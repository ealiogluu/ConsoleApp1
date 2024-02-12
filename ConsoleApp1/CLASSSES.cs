using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class program
    {
        static void main(string[] args)
        {
          CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Clear();
            customerManagement.Add();
            customerManagement.Remove();

            Console.ReadLine();
 
        }
    }

    class CustomerManagement
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        
        }

        public void Remove() 
        {
            Console.WriteLine("Customer removed");
      
        }

        public void Clear()
        {
            Console.WriteLine("Customer cleared");
        }

        
    }

        }
    

