using System;

namespace _05.EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < 5; j++)
                {
                    string currentNumberAsString = i.ToString();

                    if (j == 0 || j == 1)
                    {
                        leftSum += currentNumberAsString[j]; //j излиа като ACSII стойност, как да го изкарам като int??
                    }
                    else if (j == 3 || j == 4)
                    {
                        rightSum += currentNumberAsString[j];
                    }

                    if (leftSum < rightSum)
                    {
                        leftSum += currentNumberAsString[2];
                    }
                    else if (rightSum < leftSum)
                    {
                        rightSum += currentNumberAsString[2];
                    }

                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
