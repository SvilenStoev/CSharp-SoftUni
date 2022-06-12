using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var carMileage = new Dictionary<string, int>();
            var carFuel = new Dictionary<string, int>();


            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                List<string> commands = command.Split("|").ToList();

                if (!(carMileage.ContainsKey(commands[0])))
                {
                    carMileage[commands[0]] = int.Parse(commands[1]);
                    carFuel[commands[0]] = int.Parse(commands[2]);
                }
            }

            string otherCommands;

            while ((otherCommands = Console.ReadLine()) != "Stop")
            {
                string firstCommand = otherCommands.Split(" : ")[0];
                string car = otherCommands.Split(" : ")[1];

                switch (firstCommand)
                {
                    case "Drive":
                        int distance = int.Parse(otherCommands.Split(" : ")[2]);
                        int fuel = int.Parse(otherCommands.Split(" : ")[3]);
                        
                        if (fuel > carFuel[car])
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            carMileage[car] += distance;
                            carFuel[car] -= fuel;

                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (carMileage[car] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carMileage.Remove(car);
                            carFuel.Remove(car);
                        }
                        break;

                    case "Refuel":

                        int refuelFuel = int.Parse(otherCommands.Split(" : ")[2]);

                        if (refuelFuel > 75 - carFuel[car])
                        {
                            refuelFuel = 75 - carFuel[car];
                            carFuel[car] += refuelFuel;
                            Console.WriteLine($"{car} refueled with {refuelFuel} liters");
                        }
                        else
                        {
                            carFuel[car] += refuelFuel;
                            Console.WriteLine($"{car} refueled with {refuelFuel} liters");
                        }
                        break;

                    case "Revert":

                        int kilometers = int.Parse(otherCommands.Split(" : ")[2]);

                        if (carMileage[car] - kilometers < 10000)
                        {
                            carMileage[car] = 10000;
                        }
                        else
                        {
                            carMileage[car] -= kilometers;
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        break;
                }
            }

            var sortedCars = carMileage.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in sortedCars)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value} kms, Fuel in the tank: {carFuel[kvp.Key]} lt.");
            }
        }
    }
}
