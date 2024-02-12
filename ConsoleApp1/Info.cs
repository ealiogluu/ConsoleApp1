using ConsoleApp1;
using System.Runtime.InteropServices;


namespace ConsoleApp1
{
    internal class Info
    {
        private static void main() {

            Customer customer = new Customer();

            customer.FirstName = "Emine Nur";
            customer.LastName = "Alioglu";
            customer.City = "Istanbul";
            customer.Id = 1;        

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Ayse",
                LastName = "Alioglu"
            };


            //    int[,] number = new int[4, 3];

            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 13; j++)
            //        {
            //            new[i , j] = i + 1 + j;
            //        }


            //    }

            //    for (int i = 0; i < 4; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //            Console.WriteLine(new number[i, j]);
            //    }


            //string[,] regions = new string[4, 3]
            //{
            //    {"AB","AC","AD"},{"BB","BC","BD"}, {"CB","CC","CD"},{"DB","DC","DD"},
            //};

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++) 
            //    {
            //        Console.WriteLine(regions[i, j]);
            //    }

            //for (int i = 0; i <100;i++)
            //{
            //    if(i%2== 0) {
            //        Console.Write(i+"\t");

            //    }
            //}


            //Console.WriteLine("isim gir: ");
            //string isim = Console.ReadLine();

            //Console.WriteLine("******");
            //Console.WriteLine("isim: " + isim);

            //string sehir1 = "ankara";
            //string sehir2 = "istanbul";
            //string ikisehir = sehir1 + sehir2;

            //Console.WriteLine(ikisehir);
            //Console.ReadLine();

            //class1 ->
            //Ordering ordering = new Ordering();

            //ordering.Chicken();
            //ordering.Soup();
            //ordering.Rice();

            //Console.ReadLine();
        }
    }
}
