using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Vehicles.Common;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCREMENT = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
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

        //TODO: Много грозно стана с FUEL_CONSUMPTION_INCREMENT

        public string DriveEmpty(double distance)
        {
            double fuelNeeded = distance * (this.FuelConsumption - FUEL_CONSUMPTION_INCREMENT);

            if (fuelNeeded > this.FuelQuantity)
            {
                string excMsg = string.Format(ExceptionMessages.NotEnoughtFuelExceptionMessage, this.GetType().Name);

                throw new InvalidOperationException(excMsg);
            }

            this.FuelQuantity -= fuelNeeded;

            return $"{this.GetType().Name} travelled {distance} km";
        }

    }
}
