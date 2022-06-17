using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carDetails = Console.ReadLine().Split().ToArray();
                string carModel = carDetails[0];
                double fuelAmount = double.Parse(carDetails[1]);
                double fuelConsumptionFor1km = double.Parse(carDetails[2]);

                var currCar = new Car(carModel, fuelAmount, fuelConsumptionFor1km);

                cars.Add(currCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var driveCar = command.Split().ToArray();
                string carModelToDrive = driveCar[1];
                int amountOfKm = int.Parse(driveCar[2]);

                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model == carModelToDrive)
                    {
                        cars[i].Drive(amountOfKm);
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
