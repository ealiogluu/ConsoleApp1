using System;

namespace YeniEv
{
    internal class Program
    {
        static void Main()
        {
            HousePriceCalculator houseCalculator = new HousePriceCalculator();
            houseCalculator.EnterHouseDetails();
            houseCalculator.AreaOfRooms();
            houseCalculator.CalculatingPrice();
            houseCalculator.Choice();

            Console.ReadLine();
        }
    }
}