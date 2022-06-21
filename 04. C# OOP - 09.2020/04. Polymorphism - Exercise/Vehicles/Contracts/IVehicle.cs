﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
{
   public interface IVehicle
    {
        double FuelQuantity { get;  }

        double FuelConsumption { get; }

        double TankCapacity { get; }

        string Drive(double distance);

        void Refuel(double liters);
    }
}
