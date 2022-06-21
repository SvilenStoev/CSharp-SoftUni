using Raiding.Core;
using System;

namespace Raiding
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
