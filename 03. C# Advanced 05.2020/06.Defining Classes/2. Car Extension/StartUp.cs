using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();

            car.Make = "Honda";
            car.Year = 2007;
            car.Model = "Civic";
            car.FuelConsumption = 7.50;
            car.FuelQuantity = 10;

            Console.WriteLine(car.GetSpecifications());

            car.Drive(150);

            Console.WriteLine(car.GetSpecifications());
        }
    }
}
