using System;

namespace YeniEv
{
    public class HousePriceCalculator
    {
        public int OdaSayisi { get; set; }
        public int SalonSayisi { get; set; }
        public string DuvarRengi { get; set; }
        public int BalkonSayisi { get; set; }

        public int AreaKitchen { get; set; }
        public int AreaRooms { get; set; }
        public int AreaSaloon { get; set; }
        public int AreaBalcony { get; set; }
        public double TotalAreaHouse { get; set; }
        public double TotalPriceHouse { get; set; }


        public void IslemleriGoster()
        {
            Console.WriteLine("1- Yeni evinizin özellikleri");
            Console.WriteLine("2- Yeni evinizin ücretini öğrenin.");
            Console.WriteLine("3- Evinizin kapladığı net alan öğrenin.\n");
            Console.WriteLine("Islemi bitirmek icin 9a basınız.");
        }
        public void EvIcinIslemleriUygula()
        {
            Console.WriteLine("4- Evinizin oda sayısını seciniz.");
            Console.WriteLine("5- Evinizin salon sayısıni seciniz.");
            Console.WriteLine("6- Duvaralrınızın rengini seciniz.");
            Console.WriteLine("7- Balkon sayinizi seciniz.");
            Console.WriteLine("8- Cıkıs yap.\n ");
        }

        public void EnterHouseDetails()
        {
            Console.WriteLine("*******HOSGELDINIZ*********\n ");
            Console.WriteLine("Eviniz icin hangi ozelligi girmek istediginizi asagidan secin.\n");

            EvIcinIslemleriUygula();

            Console.WriteLine();

            bool kontrol = true;
            while (kontrol)
            {
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (secim == 4)
                {
                    Console.WriteLine("oda sayisi: ");
                    OdaSayisi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    EvIcinIslemleriUygula();
                    Console.WriteLine();

                }
                else if (secim == 5)
                {
                    Console.WriteLine("salon sayisi: ");
                    SalonSayisi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    EvIcinIslemleriUygula();
                    Console.WriteLine();
                }
                else if (secim == 6)
                {
                    Console.WriteLine("duvarlain rengi: ");
                    DuvarRengi = Console.ReadLine();
                    Console.WriteLine();
                    EvIcinIslemleriUygula();
                    Console.WriteLine();
                }
                else if (secim == 7)
                {
                    Console.WriteLine("balkon sayisi: ");
                    BalkonSayisi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    EvIcinIslemleriUygula();
                    Console.WriteLine();
                }
                else kontrol = false;
            }

            Console.ReadLine();
        }

        public void AreaOfRooms()
        {
            Console.WriteLine("Odalarin ve balkonlarin alanini seciniz:\n\n ");

            Console.WriteLine("Mutfagin alani: ");
            AreaKitchen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Odalarin alani: ");
            AreaRooms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Salonlarin/Salonun alani: ");
            AreaSaloon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Balkonlarin/balkonun alani: ");
            AreaBalcony = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

           
        }

        public void CalculatingPrice()
        {
            // m^2 basina 10 bin tl
            TotalAreaHouse = (AreaBalcony * BalkonSayisi) + AreaKitchen + (AreaRooms * OdaSayisi) + (AreaSaloon * SalonSayisi);
            TotalPriceHouse = 10000 * TotalAreaHouse;

        }

        public void Choice()
        {
            Console.WriteLine("Evinizin bilgilerini ogrenmek icin asagidan secim yapınız.\n");
            IslemleriGoster();
            Console.WriteLine("\n");

            bool exit = true;
            while(exit)
            {
                int Choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                if (Choice == 1)
                {
                    Console.WriteLine("oda sayısı ve odaların alanı: " + OdaSayisi + "," + AreaRooms);
                    Console.WriteLine("salon sayısı ve salonların alanı : " + SalonSayisi + "," + AreaSaloon);
                    Console.WriteLine("odalarınızın duvar rengi : " + DuvarRengi);
                    Console.WriteLine("balkon sayınız ve balkonların alanı: " + BalkonSayisi + "," + AreaBalcony + "\n\n");

                    IslemleriGoster();
                }
                else if (Choice == 2)
                {
                    Console.WriteLine("Yeni evinizin toplam ücreti: " + TotalPriceHouse + "\n\n");
                    IslemleriGoster();
                }
                else if (Choice == 3)
                {
                    Console.WriteLine("Yeni evinizin toplam alanı: " +TotalAreaHouse + "\n\n");
                    IslemleriGoster();

                }
                else exit = false; 

            } 
            Console.WriteLine("Bizi tercih ettiginiz icin tesekkurler..");
        }
    }
}