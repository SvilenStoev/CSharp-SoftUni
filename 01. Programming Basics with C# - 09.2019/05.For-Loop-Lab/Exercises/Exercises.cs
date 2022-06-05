using System;

namespace Exercises
{
    class Exercises
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i * number);
                number = i;
            }


        }
    }
}
