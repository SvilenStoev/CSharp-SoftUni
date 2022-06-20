using System;
using System.Collections.Generic;

namespace AddRangeExtention
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            var hashset = new HashSet<int>();

            list.AddRange<int>(new List<int> { 1, 2, 3 });


        }
    }
}
