using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

delegate void SomeDelegate(int input);

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> func = int.Parse;

            var numbers = Console.ReadLine().Split(", ").Select(func).ToList();

            Console.WriteLine(numbers.Count);
            Console.WriteLine(Sum(numbers));
        }   

        static int Sum(List<int> list)
        {
            int result = 0;

            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }

            return result;
        }
    }
}
