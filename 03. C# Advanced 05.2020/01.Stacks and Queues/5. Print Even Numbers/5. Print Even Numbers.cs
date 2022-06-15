using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            var intQueue = new Queue<int>(intArray);
            var EvenIntQueue = new Queue<int>();

            while (intQueue.Any())
            { 
                int currNumber = intQueue.Dequeue();

                if (currNumber % 2 == 0)
                {
                    EvenIntQueue.Enqueue(currNumber);
                }
            }

            Console.WriteLine(string.Join(", ", EvenIntQueue));

        }
    }
}
