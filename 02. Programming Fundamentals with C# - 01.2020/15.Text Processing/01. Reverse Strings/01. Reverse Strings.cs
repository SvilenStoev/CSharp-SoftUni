using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                var reversedInput = input.Reverse().ToArray();

                Console.WriteLine($"{input} = {String.Join("", reversedInput)}");
            }
        }
    }
}
