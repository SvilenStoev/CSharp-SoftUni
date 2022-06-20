using MilitaryElit.Core;
using MilitaryElit.Core.Conctacts;
using MilitaryElit.IO;
using MilitaryElit.IO.Contracts;
using System;

namespace MilitaryElit
{
    class StartUp
    {
        static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
