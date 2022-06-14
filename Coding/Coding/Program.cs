using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForDogs = 2.50;
            double priceForCats = 4;
            string pricePerPackageForDogs = Console.ReadLine();
            double pricePerPackageForDogsDouble = double.Parse(pricePerPackageForDogs);

            string pricePerPackageForCats = Console.ReadLine();
            double pricePerPackageForCatsDouble = double.Parse(pricePerPackageForCats);

            double totalPriceDogs = priceForDogs * pricePerPackageForDogsDouble;
            double totalPriceCats = priceForCats * pricePerPackageForCatsDouble;
            double totalPrice = totalPriceDogs + totalPriceCats;
           
            Console.WriteLine ($"{totalPrice} lv.");
        }
    }
}
