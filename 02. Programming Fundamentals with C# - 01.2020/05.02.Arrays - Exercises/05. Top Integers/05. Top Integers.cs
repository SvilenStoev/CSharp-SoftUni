using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string result = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                bool isTopInteger = true;

                for (int index = i + 1; index < arr.Length; index++)
                {
                    if (currentNumber <= arr[index])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    result += currentNumber + " ";
                }
            }

            Console.WriteLine(result);

        }
    }
}