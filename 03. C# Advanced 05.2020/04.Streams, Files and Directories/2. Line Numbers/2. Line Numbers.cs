using System;
using System.IO;
using System.Threading;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("Input2.txt");
            using var writer = new StreamWriter("Output2.txt", true);

            int count = 1;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                var convertedLine = $"{count}. {line}";

                writer.WriteLine(convertedLine);

                count++;
            }

        }
    }
}
