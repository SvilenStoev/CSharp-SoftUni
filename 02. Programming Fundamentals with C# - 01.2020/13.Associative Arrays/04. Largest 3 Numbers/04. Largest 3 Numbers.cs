using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] sorted = numbers.OrderByDescending(x => x).ToArray();


            for (int i = 0; i < 3; i++)
            {
                if (i == sorted.Length)
                {
                    break;
                }

                Console.Write(sorted[i] + " ");
            }
        }
    }
}
