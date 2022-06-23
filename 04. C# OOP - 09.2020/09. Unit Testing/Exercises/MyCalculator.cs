using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
    public class MyCalculator
    {
        /// <summary>
        /// Provides the sum of given numbers array
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public double Sum(params int[] numbers)
        {
            double result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }

            return result;
        }

        public double Product(params int[] numbers)
        {
            double result = 1;

            foreach (int number in numbers)
            {
                result *= number;
            }

            return result;
        }

    }
}
