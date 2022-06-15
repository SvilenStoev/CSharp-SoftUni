using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var intCommands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var intQueue = new Queue<int>(numbers);

            int elementsToPop = intCommands[1];
            int intToCheck = intCommands[2];

            for (int i = 0; i < elementsToPop; i++)
            {
                if (intQueue.Any())
                {
                    intQueue.Dequeue();
                }
            }

            if (intQueue.Contains(intToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (intQueue.Count > 0)
                {
                    var sortedQueue = intQueue.OrderBy(x => x).ToArray();

                    Console.WriteLine(sortedQueue[0]);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
