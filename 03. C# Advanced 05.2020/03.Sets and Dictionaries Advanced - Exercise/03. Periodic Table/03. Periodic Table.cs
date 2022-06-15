using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> periodicTable = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    periodicTable.Add(elements[j]);
                }
            }

            var orderedTables = periodicTable.OrderBy(x => x).ToHashSet();

            foreach (var element in orderedTables)
            {
                Console.Write(element + " ");
            }

        }
    }
}
