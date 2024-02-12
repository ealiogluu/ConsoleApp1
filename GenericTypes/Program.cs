using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>(); 
            myList.Add("a");
        }
    }

    class MyList<Type>
    {
        public void Add(Type item) 
        {

        }  
    }
}
