using System;

namespace StoreOfWine
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultByColor = Wine.FindColor(ColorWine.red);
            Console.WriteLine();
            var resultByYear = Wine.FindYear(2021);
            Console.WriteLine();
            var resultByColorYearString = Wine.FindYearColorStrong(ColorWine.white,2018,StrongWine.hard);
            Console.ReadLine();
        }
    }
}
