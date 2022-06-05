using System;

namespace _08.CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            bool containsEggs = false;
            bool containsFlour = false;
            bool containsSugar = false;

            for (int i = 1; i <= batches; i++)
            {
                string ingredients = string.Empty;

                while (true)
                {
                    ingredients = Console.ReadLine();
                    if (ingredients == "flour")
                    {
                        containsFlour = true;
                    }
                    else if (ingredients == "eggs")
                    {
                        containsEggs = true;
                    }
                    else if (ingredients == "sugar")
                    {
                        containsSugar = true;
                    }
                    else if (ingredients == "Bake!")
                    {
                        if (containsSugar && containsFlour && containsEggs)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    
                }

            }

        }
    }
}
