using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ownDogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());
            string currency = "lv.";
            double dogfoodPrice = 2.50;
            double animalfoodPrice = 4;
            double totaldogfoodPrice = ownDogs * dogfoodPrice;
            double totalanimalfoodPrice = otherAnimals * animalfoodPrice;

            Console.WriteLine("{0:F2} {1}", totaldogfoodPrice + totalanimalfoodPrice, currency);


        }
    }
}