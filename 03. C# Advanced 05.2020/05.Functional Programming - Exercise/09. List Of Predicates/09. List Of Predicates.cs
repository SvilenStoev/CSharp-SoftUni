using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            //как да я реша с функционално?

            int lastNumber = int.Parse(Console.ReadLine());

            var numbersSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var specialNumbers = new List<int>();

            for (int i = 1; i <= lastNumber; i++)
            {
                bool isValidNumber = true;

                for (int k = 0; k < numbersSequence.Count; k++)
                {
                    if (i % numbersSequence[k] != 0)
                    {
                        isValidNumber = false;
                    }
                }

                if (isValidNumber)
                {
                    specialNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", specialNumbers));
        }
    }
}
