using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnNTimesInput(input, count));
        }

        static StringBuilder ReturnNTimesInput(string text, int n)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                result.Append(text);
            }
            return result;
        }

    }
}
