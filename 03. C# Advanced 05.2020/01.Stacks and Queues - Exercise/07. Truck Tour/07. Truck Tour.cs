using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pumpsStack = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] currPump = Console.ReadLine().Split().Select(int.Parse).ToArray();

                pumpsStack.Enqueue(currPump);
            }

            int bestPumpIndex = 0;

            while (true)
            {
                int truckTank = 0;
                bool foundPoint = true;

                for (int i = 0; i < n; i++)
                {
                    int[] currPump = pumpsStack.Dequeue();

                    truckTank += currPump[0];

                    if (truckTank < currPump[1])
                    {
                        foundPoint = false;
                    }

                    truckTank -= currPump[1];

                    pumpsStack.Enqueue(currPump);
                }

                if (foundPoint)
                {
                    break;
                }

                pumpsStack.Enqueue(pumpsStack.Dequeue());
                bestPumpIndex++;
            }

            Console.WriteLine(bestPumpIndex);
        }
    }
}
