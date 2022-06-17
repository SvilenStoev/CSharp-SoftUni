using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            AddEngine(n, engines);

            int m = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            AddCar(engines, m, cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        private static void AddCar(List<Engine> engines, int m, List<Car> cars)
        {
            for (int i = 0; i < m; i++)
            {
                var carDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                Car currCar = null;

                string model = carDetails[0];
                Engine engine = engines.First(e => e.Model == carDetails[1]);

                if (carDetails.Count == 2)
                {
                    currCar = new Car(model, engine);
                }
                else if (carDetails.Count == 3)
                {
                    double weight;

                    bool isWeight = double.TryParse(carDetails[2], out weight);

                    if (isWeight)
                    {
                        currCar = new Car(model, engine, weight);
                    }
                    else
                    {
                        currCar = new Car(model, engine, carDetails[2]);
                    }
                }
                else if (carDetails.Count == 4)
                {
                    int weight = int.Parse(carDetails[2]);
                    string color = carDetails[3];

                    currCar = new Car(model, engine, weight, color);
                }

                if (currCar != null)
                {
                    cars.Add(currCar);
                }
            }
        }

        private static void AddEngine(int n, List<Engine> engines)
        {
            for (int i = 0; i < n; i++)
            {
                var engineDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string model = engineDetails[0];
                int power = int.Parse(engineDetails[1]);

                Engine currEngine = null;

                if (engineDetails.Count == 4)
                {
                    int displacement = int.Parse(engineDetails[2]);
                    string efficiency = engineDetails[3];

                    currEngine = new Engine(model, power, displacement, efficiency);

                }
                else if (engineDetails.Count == 3)
                {
                    int displacement;

                    bool isDisplacement = int.TryParse(engineDetails[2], out displacement);

                    if (isDisplacement)
                    {
                        currEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        currEngine = new Engine(model, power, engineDetails[2]);
                    }

                }
                else if (engineDetails.Count == 2)
                {
                    currEngine = new Engine(model, power);
                }

                if (currEngine != null)
                {
                    engines.Add(currEngine);
                }
            }
        }
    }
}
