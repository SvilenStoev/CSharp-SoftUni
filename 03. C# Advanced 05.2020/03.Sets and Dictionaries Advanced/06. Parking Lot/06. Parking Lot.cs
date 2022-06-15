using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> parkingLot = new HashSet<string>();

            while (command != "END")
            {
                string[] commands = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string direction = commands[0];
                string carNumber = commands[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else
                {
                    parkingLot.Remove(carNumber);
                }

                command = Console.ReadLine();
            }

            if (parkingLot.Any())
            {
                foreach (string carNumber in parkingLot)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
          
        }
    }
}
