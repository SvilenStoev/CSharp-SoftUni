using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int index = 0;


            for (int j = 0; j < arr.Length; j++)
            {
                index = j;
                int leftSum = 0;
                int rightSum = 0;

                for (int i = index; i < arr.Length - 1; i++)
                {
                    rightSum += arr[i + 1];
                }

                for (int i = index - 1; i >= 0; i--)
                {
                    leftSum += arr[i];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(index);
                    return;
                }

            }

            Console.WriteLine("no");

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    leftSum += arr[i];
            //    int rightSum = 0;

            //    for (int j = arr.Length - 1; j > i - 1; j--)
            //    {
            //        rightSum += arr[j];

            //        if (rightSum == leftSum)
            //        {
            //            result = i + 1;
            //            break;
            //        }
            //    }

            //    if (result != 0)
            //    {
            //        break;
            //    }
            //}

            //if (true)
            //{

            //}
            //Console.WriteLine(result);


        }
    }
}
