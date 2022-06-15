using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var trafficJamQueue = new Queue<string>();
            string command;
            int carPasses = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (trafficJamQueue.Any())
                        {
                            string currCar = trafficJamQueue.Dequeue();
                            Console.WriteLine($"{currCar} passed!");
                            carPasses++;
                        }
                    }
                }
                else
                {
                    trafficJamQueue.Enqueue(command);
                }
            }

            Console.WriteLine($"{carPasses} cars passed the crossroads.");
        }
    }
}
