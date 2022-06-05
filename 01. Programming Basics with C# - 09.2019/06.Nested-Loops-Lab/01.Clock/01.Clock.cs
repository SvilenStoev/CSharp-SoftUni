using System;

namespace _01.Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int i = 0; i <= 59; i++)
                    {
                        Console.WriteLine($"{hours}:{minutes}:{i}");
                    }
                }
            }


        }
    }
}
