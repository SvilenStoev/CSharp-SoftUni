using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers[number] = 0;
                }

                numbers[number]++;
            }

            //foreach (var (key, value) in numbers)
            //{
            //    if (value % 2 == 0)
            //    {
            //        Console.WriteLine(key);
            //    }
            //}

            KeyValuePair<int, int> evenNumber = numbers.First(kvp => kvp.Value % 2 == 0);

            Console.WriteLine(evenNumber.Key);

        }
    }
}
