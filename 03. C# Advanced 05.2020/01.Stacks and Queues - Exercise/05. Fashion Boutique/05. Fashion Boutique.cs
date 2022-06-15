using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var boxElementsAsStack = new Stack<int>(boxElements);
            int rackCapacity = int.Parse(Console.ReadLine());

            int racksUsed = 1;
            int sumOfCurrRack = 0;

            while (boxElementsAsStack.Any())
            {
                sumOfCurrRack += boxElementsAsStack.Peek();

                if (sumOfCurrRack <= rackCapacity)
                {
                    boxElementsAsStack.Pop();
                }
                else if (rackCapacity == 0)
                {
                    break;
                }
                else
                {
                    sumOfCurrRack = 0;
                    racksUsed++;
                }
            }

            Console.WriteLine(racksUsed);

        }
    }
}
