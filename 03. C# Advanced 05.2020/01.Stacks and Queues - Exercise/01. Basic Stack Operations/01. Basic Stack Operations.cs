using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var intCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToPush = intCommands[0];
            int elementsToPop = intCommands[1];
            int intToCheck = intCommands[2];

            var intStack = new Stack<int>(numbers);

            for (int i = 0; i < elementsToPop; i++)
            {
                if (intStack.Any())
                {
                    intStack.Pop();
                }
            }

            if (intStack.Contains(intToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (intStack.Count > 0)
                {
                    var sortedStack = intStack.OrderBy(x => x).ToArray();

                    Console.WriteLine(sortedStack[0]);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }


        }
    }
}
