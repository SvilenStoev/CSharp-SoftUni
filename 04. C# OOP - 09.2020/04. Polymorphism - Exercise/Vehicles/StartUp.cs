using System;
using System.Linq;
using Vehicles.Contracts;
using Vehicles.Models;
using Vehicles.Core;

namespace Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
