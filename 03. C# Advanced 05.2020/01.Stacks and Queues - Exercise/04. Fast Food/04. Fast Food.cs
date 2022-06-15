using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());

            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ordersQueue = new Queue<int>(orders);

            Console.WriteLine(ordersQueue.Max());

            while (ordersQueue.Any())
            {
                if (totalFood >= ordersQueue.Peek())
                {
                    int servedFood = ordersQueue.Dequeue();
                    totalFood -= servedFood;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
                    break;
                }
            }

            if (!ordersQueue.Any())
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
