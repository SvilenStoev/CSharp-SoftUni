using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public class ConsoleIntroducer : IIntroducer
    {
        public void Introduce(string message)
        {
            Console.WriteLine(message);
        }
    }
}
