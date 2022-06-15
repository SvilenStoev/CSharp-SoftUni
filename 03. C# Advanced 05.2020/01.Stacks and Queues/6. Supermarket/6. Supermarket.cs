using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleQueue = new Queue<string>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    Console.WriteLine(string.Join("\n", peopleQueue));
                    peopleQueue.Clear();
                }
                else
                {
                    peopleQueue.Enqueue(command);
                }
            }

            Console.WriteLine($"{peopleQueue.Count} people remaining.");
        }
    }
}
