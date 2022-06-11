using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Train
{
    class Train
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string input;

            
            while ((input = Console.ReadLine()) != "end") 
            {
                string command = input.Split()[0];

                if (command == "Add")
                {
                    wagons.Add(int.Parse(input.Split()[1]));
                }
                else
                {
                    int addPassengers = int.Parse(input);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + addPassengers) <= wagonCapacity)
                        {
                            wagons[i] += addPassengers;
                            break;
                        }
                    }
                }
            }

            Console.Write(string.Join(" ", wagons));
        }
    }
}
