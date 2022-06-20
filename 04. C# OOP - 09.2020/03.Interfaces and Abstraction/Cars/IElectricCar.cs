using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    internal interface IElectricCar : ICar
    {
        int Battery { get; }
    }
}
