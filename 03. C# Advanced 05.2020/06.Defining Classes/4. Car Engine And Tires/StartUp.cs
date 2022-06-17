using System;
using System.Text;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var engine = new Engine(500, 6.0);
            var tires = new Tire[]
            {
                new Tire(2020, 3),
                new Tire(2020, 3),
                new Tire(2020, 3),
                new Tire(2020, 3)
            };

            var car = new Car("VW", "Golf", 2200, 200, 15, engine, tires);

        }
    }
}
