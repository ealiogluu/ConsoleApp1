using ConsoleApp1;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main()
    {
        //10ciftsayitoplama


        //int result = 0;


        //for (int i = 0; i < 10; i++) 
        //{
        //    Console.WriteLine("Bir sayi girin: ");

        //    var number = Convert.ToInt32(Console.ReadLine());

        //    if (number % 2 == 0)
        //        result += number;
        //    else i--;

        //}

        //Console.WriteLine("Toplam: " + result);
        //Console.ReadLine();


        // Person person1 = new Person();  
        // Person person2 = new Person();  

        // person1.FirstName = "Ayse";
        // person2 = person1;

        //Employee employee = new Employee();
        // employee.EmployeeNo = 1;




        // Console.WriteLine(person1.FirstName);
        // Console.WriteLine(person2.FirstName);

        Customer customer1 = new Customer() { Id = 1, City = "Istanbul", FirstName = "Ayse", LastName = "Aliog", };
        Customer customer2 = new Customer(2,"Ankara","Emine","Alioglu") ;

        Console.WriteLine(customer1.City +"\t"+ customer1.FirstName);
        Console.WriteLine(customer2.Id);
        

    }

    class Customer
    {
        public Customer()
        {
            //Yapıcı Metot

        }

        public Customer(int id, string city, string firstName, string lastName)
        {
            Id = id;
            City = city;
            FirstName = firstName;
            LastName = lastName;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }
        public string City { get; set; }       

    }   

   

    //class Person
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }

    //}

    //class Customer:Person
    //{
        
    //    public int CustomerNo { get; set; }
    //}

    //class Employee:Person
    //{
    //    public int EmployeeNo { get; set;}
    //}
}
 
