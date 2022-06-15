using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("text.txt");

            int count = 0;

            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    line = ReplaceChar(line);
                    line = String.Join(" ", line
                        .Split(' ')
                        .Reverse());

                    Console.WriteLine(line);
                }

                count++;
            }
        }

        private static string ReplaceChar(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '-' || 
                    line[i] == ',' || 
                    line[i] == '.' || 
                    line[i] == '!' || 
                    line[i] == '?')
                {
                    line = line.Replace(line[i],'@');
                }
            }

            return line;
        }
    }
}
