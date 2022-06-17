using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> minFunc = (arr) =>
            {
                int minValue = int.MaxValue;

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] < minValue)
                    {
                        minValue = arr[i];
                    }
                }

                return minValue;
            };

            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(minFunc(array));
        }
    }
}
