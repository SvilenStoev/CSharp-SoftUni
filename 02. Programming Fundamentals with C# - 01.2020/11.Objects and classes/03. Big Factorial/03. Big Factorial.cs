﻿using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger number = 1;

            for (int i = 2; i <= n; i++)
            {
                number *= i;
            }

            Console.WriteLine(number);

        }
    }
}
