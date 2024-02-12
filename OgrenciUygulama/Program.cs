using System;                                                                                                                                                
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(234, "Emine", "Alioglu", 78, 95, 89, "IstanbulAydınUnı");


            Console.WriteLine("Hosgeldiniz.. Yapmak istediginiz islemi seciniz");


            while (kontrol)
            {
                IslemleriGoster();
                string secim = Console.ReadLine();


                switch (secim)
                {
                    case "1": ogrenci1.OgrenciBilgileriGoster(); break;

                    case "2":
                        double ogrenciOrtalama = ogrenci1.OgrenciNotuBul();
                        Console.WriteLine("Ogrencinin Ortalamasi: " + ogrenciOrtalama); break;

                    case "3": ogrenci1.OkulBul(); break;

                    case "4": kontrol = false; break;
                }

            }

        }

        //do
        //{
        //    IslemleriGoster();
        //    string secim = Console.ReadLine();


        //    switch (secim)
        //    {
        //        case "1": ogrenci1.OgrenciBilgileriGoster(); break;

        //        case "2":
        //            double ogrenciOrtalama = ogrenci1.OgrenciNotuBul();
        //            Console.WriteLine("Ogrencinin Ortalamasi: " + ogrenciOrtalama); break;

        //        case "3": ogrenci1.OkulBul(); break;

        //    }
        //} while (secim = "4");




        static void IslemleriGoster()
        {
            Console.WriteLine("1-Ogrenci Bilgilerini göster");
            Console.WriteLine("2-Ogrenci ortalamaasını goster");
            Console.WriteLine("3-Ogrencinin okulunu goster");
            Console.WriteLine("4-Cıkıs yap");

        }
    
    }
}
