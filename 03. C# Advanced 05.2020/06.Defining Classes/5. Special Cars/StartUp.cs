using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var tires = new List<Tire[]>();

            while (command != "No more tires")
            {
                var currTiresArray = command.Split().ToArray();
                Tire[] currTiresPair = new Tire[4];
                int counter = 0;

                for (int i = 0; i < currTiresArray.Length; i += 2)
                {
                    int currTireYear = int.Parse(currTiresArray[i]);
                    double currTirePressure = double.Parse(currTiresArray[i + 1]);

                    var currTire = new Tire(currTireYear, currTirePressure);

                    currTiresPair[counter] = currTire;
                    counter++;
                }
                tires.Add(currTiresPair);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            var engines = new List<Engine>();

            while (command != "Engines done")
            {
                var currEngineArray = command.Split().ToArray();

                for (int i = 0; i < currEngineArray.Length; i += 2)
                {
                    int currEngineHorsePower = int.Parse(currEngineArray[i]);
                    double currEngineCubicCapacity = double.Parse(currEngineArray[i + 1]);

                    var currEngine = new Engine(currEngineHorsePower, currEngineCubicCapacity);

                    engines.Add(currEngine);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            var cars = new List<Car>();

            while (command != "Show special")
            {
                var currCarArray = command.Split().ToArray();

                string currCarMake = currCarArray[0];
                string currCarModel = currCarArray[1];
                int currCarYear = int.Parse(currCarArray[2]);
                double currCarFuelQuantity = double.Parse(currCarArray[3]);
                double currCarFuelConsumption = double.Parse(currCarArray[4]);
                int currCarEngineIndex = int.Parse(currCarArray[5]);
                int currCarTiresIndex = int.Parse(currCarArray[6]);
                Engine currCarEngine = engines[currCarEngineIndex];
                Tire[] currCarTires = tires[currCarTiresIndex];

                var currCar = new Car(currCarMake, currCarModel, currCarYear, currCarFuelQuantity, currCarFuelConsumption, currCarEngine, currCarTires);

                cars.Add(currCar);

                command = Console.ReadLine();
            }

            for (int i = 0; i < cars.Count; i++)
            {
                var currCar = cars[i];
                double currCarTiresPressure = 0;

                for (int j = 0; j < currCar.Tires.Length; j++)
                {
                    currCarTiresPressure += double.Parse(currCar.Tires[j].Pressure.ToString());
                }

                if (currCar.Year >= 2017 && currCar.Engine.HorsePower > 330 && currCarTiresPressure > 9 && currCarTiresPressure < 10)
                {
                    currCar.Drive(20);
                    Console.WriteLine(currCar.GetSpecifications());
                }
            }
        }
    }
}
