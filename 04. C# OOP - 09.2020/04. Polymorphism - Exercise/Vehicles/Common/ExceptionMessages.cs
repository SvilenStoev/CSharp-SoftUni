using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Common
{
    public static class ExceptionMessages
    {
        public static string NotEnoughtFuelExceptionMessage = "{0} needs refueling";
        public static string NotEnoughtTankCapacityExceptionMessage = "Cannot fit {0} fuel in the tank";
        public static string FuelCanNotBeZeroExceptionMessage = "Fuel must be a positive number";
    }
}
