using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public interface IVehicle
    {
        string Model { get; }

        string Move();

    }
}
