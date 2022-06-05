using System;
using System.Threading;


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Clear();
                i--;
            }

            Console.WriteLine("Happy New Year! 2020 *****");

        }
    }
}
