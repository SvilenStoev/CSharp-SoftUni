using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var random1 = new Random();
            var random2 = new Random();
            var random3 = new Random();
            var random4 = new Random();
            var random5 = new Random();
            var random6 = new Random();

            string command = Console.ReadLine();
            string current = "";
            var regNumbersData = new List<string>();

            while (command != "Stop")
            {
                current = $"CB{random1.Next(1, 3)}" +
                     $"{random2.Next(1, 3)}" +
                     $"{random3.Next(1, 3)}" +
                     $"{random4.Next(1, 3)}" +
                     $"{(char)(random5.Next(65, 67))}" +
                     $"{(char)(random6.Next(65, 67))}";

                if (regNumbersData.Contains(current))
                {
                    continue;
                }

                Console.WriteLine(current);

                regNumbersData.Add(current);

                //command = Console.ReadLine(); 
            }
        }
    }
}
