using System;

namespace Exercises
{
    class Program
    {
        public static void Main()
        {
            Shape shape = new Circle();

            var asr = new Airplane();
        }

        public class Shape { }
        public class Circle : Shape { }
    }
}
