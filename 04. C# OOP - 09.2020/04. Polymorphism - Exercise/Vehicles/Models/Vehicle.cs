using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public virtual double FuelConsumption { get; protected set; }

        public double TankCapacity { get; protected set; }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }

        public virtual string Drive(double distance)
        {
            double fuelNeeded = distance * this.FuelConsumption;

            if (fuelNeeded > this.FuelQuantity)
            {
                string excMsg = string.Format(ExceptionMessages.NotEnoughtFuelExceptionMessage, this.GetType().Name);

                throw new InvalidOperationException(excMsg);
            }

            this.FuelQuantity -= fuelNeeded;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            bool isEnoughtSpace = (this.FuelQuantity + liters) <= this.TankCapacity;

            if (liters <= 0)
            {
                string msgEx = ExceptionMessages.FuelCanNotBeZeroExceptionMessage;

                throw new ArgumentException(msgEx);
            }
            else if (isEnoughtSpace)
            {
                this.FuelQuantity += liters;
            }
            else
            {
                string msgEx = string.Format(ExceptionMessages.NotEnoughtTankCapacityExceptionMessage, liters.ToString());

                throw new ArgumentException(msgEx);
            }
        }
    }
}
