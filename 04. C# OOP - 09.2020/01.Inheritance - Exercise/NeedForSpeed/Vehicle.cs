using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
        }

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public double DefaultFuelConsumption { get; internal set; }

        public virtual double FuelConsumption { get; internal set; }

        public virtual void Drive(double kilometers)
        {
            this.FuelConsumption = this.DefaultFuelConsumption * kilometers;

            this.Fuel = this.Fuel - this.FuelConsumption;
        }


    }
}
