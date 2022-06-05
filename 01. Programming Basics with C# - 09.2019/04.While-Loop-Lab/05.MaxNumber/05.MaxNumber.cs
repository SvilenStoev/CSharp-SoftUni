using System;

namespace _05.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int input = 0;
            int maxNumber = int.MinValue;

            while (counter < n)
            {
                input = int.Parse(Console.ReadLine());
                counter++;
                if (maxNumber < input)
                {
                    maxNumber = input;
                }
            }

            Console.WriteLine(maxNumber);



        }
    }
}
