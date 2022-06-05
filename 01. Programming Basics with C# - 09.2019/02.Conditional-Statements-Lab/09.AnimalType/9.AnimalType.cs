using System;

namespace _09.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
            •	dog -> mammal
            •	crocodile, tortoise, snake -> reptile
            •	others -> unknown*/

            string name = Console.ReadLine();

            switch (name)
            {
                case "dog":
                    Console.WriteLine("mammal"); break;
                case "crocodile":
                    Console.WriteLine("reptile"); break;
                case "tortoise":
                    Console.WriteLine("reptile"); break;
                case "snake":
                    Console.WriteLine("reptile"); break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
