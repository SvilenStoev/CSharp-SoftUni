using MilitaryElit.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElit.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
