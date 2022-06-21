using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        public Engine()
        {

        }

        public void Run()
        {
            IVehicle car = null;
            IVehicle truck = null;
            Bus bus = null;

            for (int i = 0; i < 3; i++)
            {
                string[] vehicleArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string vehicleType = vehicleArgs[0];
                double fuelQuantity = double.Parse(vehicleArgs[1]);
                double litersPerKm = double.Parse(vehicleArgs[2]);
                double tankCapacity = double.Parse(vehicleArgs[3]);

                if (vehicleType == "Car")
                {
                    car = new Car(fuelQuantity, litersPerKm, tankCapacity);
                }
                else if (vehicleType == "Truck")
                {
                    truck = new Truck(fuelQuantity, litersPerKm, tankCapacity);
                }
                else if (vehicleType == "Bus")
                {
                    bus = new Bus(fuelQuantity, litersPerKm, tankCapacity);
                }
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                string vehicle = commands[1];
                double inputData = double.Parse(commands[2]);

                switch (command)
                {
                    case "Drive":

                        DriveVehicle(car, truck, bus, vehicle, inputData);

                        break;

                    case "DriveEmpty":

                        try
                        {
                            bus.DriveEmpty(inputData);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case "Refuel":

                        RefuelVehicle(car, truck, bus, vehicle, inputData);

                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void RefuelVehicle(IVehicle car, IVehicle truck, IVehicle bus, string vehicle, double inputData)
        {
            try
            {
                if (vehicle == "Car")
                {
                    car.Refuel(inputData);
                }
                else if (vehicle == "Truck")
                {
                    truck.Refuel(inputData);
                }
                else if (vehicle == "Bus")
                {
                    bus.Refuel(inputData);
                }

            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
        }

        private static void DriveVehicle(IVehicle car, IVehicle truck, IVehicle bus, string vehicle, double inputData)
        {
            try
            {
                if (vehicle == "Car")
                {
                    Console.WriteLine(car.Drive(inputData));
                }
                else if (vehicle == "Truck")
                {
                    Console.WriteLine(truck.Drive(inputData));
                }
                else if (vehicle == "Bus")
                {
                    Console.WriteLine(bus.Drive(inputData));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
