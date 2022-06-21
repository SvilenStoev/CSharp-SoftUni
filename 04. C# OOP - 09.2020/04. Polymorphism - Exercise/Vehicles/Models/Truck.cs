using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCREMENT = 1.6;
        private const double REFUEL_EFFICIENCY_PERCENTAGE = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption;
            }

            protected set
            {
                base.FuelConsumption = value + FUEL_CONSUMPTION_INCREMENT;
            }
        }

        public override void Refuel(double liters)
        {
            bool isEnoughtSpace = (this.FuelQuantity + liters) <= this.TankCapacity;

            if (!isEnoughtSpace)
            {
                base.Refuel(liters);
            }
            else
            {
                base.Refuel(liters * REFUEL_EFFICIENCY_PERCENTAGE);
            }
        }
    }
}

