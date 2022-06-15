using System;
using System.IO;

namespace _1._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("Input.txt");

            int count = 0;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (count % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                count++;
            }

            


        }
    }
}
