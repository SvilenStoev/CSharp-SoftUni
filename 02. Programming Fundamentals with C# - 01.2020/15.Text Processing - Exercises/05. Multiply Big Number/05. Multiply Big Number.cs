using System;
using System.Numerics;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = Console.ReadLine().ToCharArray();
            int n = int.Parse(Console.ReadLine());

            int result;
            int remaining = 0;
            StringBuilder stringResult = new StringBuilder();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(numbers[i].ToString());

                int currentResult = ((currentNumber * n) + remaining);

                remaining = currentResult / 10;

                stringResult.Append(currentResult % 10);
            }

            if (remaining != 0)
            {
                stringResult.Append(remaining);
            }

            List<char> resultArr = stringResult.ToString().Reverse().ToList();

            var finalResult = RemoveTrailingZeroes(resultArr);

            Console.WriteLine(string.Join("", finalResult));

        }

        static List<char> RemoveTrailingZeroes(List<char> resultArr)
        {

            for (int i = 0; i < resultArr.Count; i++)
            {
                if (resultArr[i] == '0')
                {
                    resultArr.RemoveAt(i);
                }
            }

            return resultArr;
        }

    }
}
