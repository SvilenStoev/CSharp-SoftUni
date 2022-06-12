using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            double number = 0;
            double result = 0;

            for (int i = 0; i < input.Count; i++)
            {
                string currentString = input[i];
                number = double.Parse(currentString.Substring(1, currentString.Length - 2));
                int indexOfLastLetter = currentString.Length - 1;

                if (currentString[0] >= 65 && currentString[0] <= 90)
                {
                    number = number / (currentString[0] - 64);
                }
                else
                {
                    number = number * (currentString[0] - 96);
                }

                if (currentString[indexOfLastLetter] >= 65 && currentString[indexOfLastLetter] <= 90)
                {
                    number = number - (currentString[indexOfLastLetter] - 64);
                }
                else
                {
                    number = number + (currentString[indexOfLastLetter] - 96);
                }

                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
