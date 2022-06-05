using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDogs = int.Parse(Console.ReadLine());
            int numAnimals = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"{numDogs * 2.5 + numAnimals * 4:f2} lv."); //Интерколация


        }
    }
}
