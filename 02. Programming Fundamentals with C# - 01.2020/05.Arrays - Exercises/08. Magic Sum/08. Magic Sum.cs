using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            int sumOfPairs = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currNum = i;

                for (int j = currNum + 1; j < arr.Length; j++)
                {
                    sumOfPairs = arr[i] + arr[j];

                    if (sumOfPairs == number)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                    }
                }
            }
        }
    }
}
