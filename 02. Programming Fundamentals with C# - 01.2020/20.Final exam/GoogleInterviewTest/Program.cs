using System;
using System.Linq;

namespace GoogleInterviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 24, 51, 1, 3, 5, 1, 6, 219, 155, -6 };
            int[] arr2 = new int[] { 159, 59, 21, 1, 53, 21, 49, 154 };
            int[] result = new int[2];

            int target = 15;
            int difference = int.MaxValue;
            int sum = 0;

            ////Сбора от коя двойка числа е най-близко до 15

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (Math.Abs((arr1[i] + arr2[j]) - target) < difference)
            //        {
            //            difference = Math.Abs((arr1[i] + arr2[j]) - target);

            //            result[0] = arr1[i];
            //            result[1] = arr2[j];
            //        }
            //    }
            //}

            var sortedFirstArray = arr1.OrderBy(x => x).ToArray();
            var sortedSecondArray = arr2.OrderBy(x => x).ToArray();

            int x = sortedFirstArray.Length - 1;
            int y = 0;

            while (x >= 0 && y < sortedSecondArray.Length)
            {
                sum = sortedFirstArray[x] + sortedSecondArray[y];

                if (Math.Abs(sum - target) < difference)
                {
                    result[0] = sortedFirstArray[x];
                    result[1] = sortedSecondArray[y];
                    difference = Math.Abs(sum - target);
                }

                if (sum >= target)
                {
                    x--;
                }
                else
                {
                    y++;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
