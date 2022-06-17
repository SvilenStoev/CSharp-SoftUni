using System;
using System.Collections.Generic;
using System.Linq;

namespace MyList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            var removed = myList.RemoveAll(n => n % 2 == 0);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(removed);

            Console.WriteLine();

            var text = "Svilen Stoev";

            text = text.ApplyWhiteSpace(10);

            Console.WriteLine(text);
        }
    }
}
