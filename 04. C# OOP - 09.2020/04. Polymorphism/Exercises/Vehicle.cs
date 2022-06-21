using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public abstract class Vehicle : IVehicle
    {
        public string Model { get; set; }

        public virtual string Move()
        {
            return "Vehicle is moving";
        }
     
    }
}
