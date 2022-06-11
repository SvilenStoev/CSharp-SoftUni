using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Random random = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                int index = random.Next(0, input.Count);

                string temp = input[index];
                input[index] = input[i];
                input[i] = temp;

            }

            Console.WriteLine(string.Join("\n", input));

        }
    }
}
