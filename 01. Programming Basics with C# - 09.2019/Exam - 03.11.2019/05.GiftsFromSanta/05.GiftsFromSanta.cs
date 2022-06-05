using System;

namespace _05.GiftsFromSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            int counter = M;

            while (counter >= N)
            {
                if (counter % 2 == 0 && counter % 3 == 0)
                {
                    if (counter == S)
                    {
                        break;
                    }

                    Console.Write($"{counter} ");
                }

                counter--;
            }
        }
    }
}
