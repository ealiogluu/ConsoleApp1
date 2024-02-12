using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operating
{
    internal class Program
    {

        public static void Topla(int sayi1, int sayi2)
        {
            Console.WriteLine("Toplam: " + (sayi1 + sayi2));
        }

        void Cıkart(int sayi1, int sayi2)
        {
            Console.WriteLine("Sonuc: " + (sayi1 - sayi2));
        }


        static void Main(string[] args)
        {
            //double midterm; double final;  double total;

            //Console.WriteLine("enter the midterm point: ");
            //midterm= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the final point: ");
            //final = Convert.ToDouble(Console.ReadLine());


            //PRIME NUMBER FINDING

            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i =2; i < number-1; i++) {

                if (number % i == 0)
                {
                    count = 1;
                    break;

                }

                else continue;
            }

            if (count>0 )
            {
                Console.WriteLine("It is not a prime number.");
                
            }
            else
            {
                Console.WriteLine(number + " is a prime number.");
                
            }


            Console.WriteLine("Enter 2 numbers: ");
            var sayi1 = Convert.ToInt32(Console.ReadLine());
            var sayi2 = Convert.ToInt32(Console.ReadLine());

            Topla(sayi1, sayi2);



        }
    }

    
}
