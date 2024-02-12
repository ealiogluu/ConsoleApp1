using System;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pwd = Console.ReadLine();

            var customerManager = new CustomerManager(pwd);   
            customerManager.Logger = new FileLogger();
            customerManager.Add();           
            customerManager.Add();

            Console.ReadLine();
        }
    }


    class CustomerManager
    {
        private string password;
        private string SQLPassword = "123";

        public ILogger Logger { get; set; }

        public bool Add()
        {
            if(password == SQLPassword)
            {
                Logger.Log();
                Console.WriteLine("Customer Added\n");

                return true;
            }
            else
            {
                Console.WriteLine("Şifre yanlış!");
                return false;
            }
        }

        public CustomerManager(string password)
        {
            this.password = password;
            //Logger = new DataBaseLogger();  
        }
      
    }

    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine ("Logged to database"); 
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    interface ILogger 
    {
        void Log();
    }   
}