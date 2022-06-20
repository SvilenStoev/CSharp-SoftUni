using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();

            stack.AddRange(new List<string> { "Ivan", "Gosho" });


        }
    }
}
