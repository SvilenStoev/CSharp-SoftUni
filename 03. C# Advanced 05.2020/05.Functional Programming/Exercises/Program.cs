using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new List<int> { 1, 2 };


            Console.WriteLine(obj.GetType());
        }
    }
}
