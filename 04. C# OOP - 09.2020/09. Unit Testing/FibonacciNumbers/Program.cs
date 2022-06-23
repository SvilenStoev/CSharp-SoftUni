using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поредицата от числа на Фибоначи е (n = n-1 + n-2):
            //1
            //1
            //2
            //3
            //.
            //.
            //.
            //144

            //Първото 3 цифрено число е на 12-та позиция. Намери позицията на първото с 1000 цифри.

            var number = new BigInteger(2);
            var numbers = new List<BigInteger> { 1, 1 };
            int searchedLength = 1000;
            int currNumberLength;

            for (int i = 2; ; i++)
            {
                number = numbers[i - 1] + numbers[i - 2];
                numbers.Add(number);

                currNumberLength = numbers[i].ToString().Length;

                if (currNumberLength == searchedLength)
                {
                    Console.WriteLine($"The first number with length: {searchedLength} is on {i + 1} position.");
                    Console.WriteLine(numbers[i]);
                    
                    break;
                }
            }

            Console.WriteLine("---------------------------------------");

        }
    }
}
