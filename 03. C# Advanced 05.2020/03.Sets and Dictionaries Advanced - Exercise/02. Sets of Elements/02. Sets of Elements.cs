﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secondSet.Add(number);
            }

            foreach (int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
