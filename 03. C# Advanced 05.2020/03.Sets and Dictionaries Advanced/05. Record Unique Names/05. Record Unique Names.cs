using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string currName = Console.ReadLine();

                uniqueNames.Add(currName);
            }

            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
