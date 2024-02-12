using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); 
            customer.Name = "Test";
            customer.LastName = "Test"; 
            customer.Id = 1;

            Person[] persons = new Person[3]
            {
                new Person { Name="Ayse", Id=2, LastName="abi" }, new Customer{Name= "fatma", LastName="Kaya", Id=3, CreditCardNo= 45, }, new Student{Name="Ayca" }
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name + "-" + person.Id);
                
            }
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
            
     
    } //customerın üstü persondır. customera ait özel özellikelr olabilir(farklı)

    class Customer: Person 
    {
        public int CreditCardNo { get; set; }
    }

    class Student : Person
    {
        public int Department { get; set; }
    }
}
