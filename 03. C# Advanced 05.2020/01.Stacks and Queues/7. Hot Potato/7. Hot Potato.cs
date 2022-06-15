using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());

            var queueChildren = new Queue<string>(children);

            int currIndex = 1;

            while (queueChildren.Count > 1)
            {
                string currentName = queueChildren.Dequeue();

                if (currIndex == n)
                {
                    Console.WriteLine($"Removed {currentName}");
                    currIndex = 0;
                }
                else
                {
                    queueChildren.Enqueue(currentName);
                }

                currIndex++;
            }

            Console.WriteLine($"Last is {queueChildren.Peek()}");
        }
    }
}
