using System;

namespace _04.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да я реша! КОпнах я!


            int howMany = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int firstNum = 0;
            int secondNum = 0;
            int sum1 = 0;
            int sum2 = 0;
            int checker = 1;
            if (howMany > 1)
            {
                for (int i = 0; i < howMany; i++)
                {
                    firstNum = int.Parse(Console.ReadLine());
                    secondNum = int.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        sum1 = firstNum + secondNum;
                    }
                    else
                    {
                        sum2 = firstNum + secondNum;
                    }

                    if (sum1 == sum2)
                    {
                        checker++;

                    }
                    if (i >= 1 && sum1 != sum2)
                    {
                        if (max < (Math.Abs(sum2 - sum1)))
                        {
                            max = Math.Abs(sum2 - sum1);
                        }
                    }
                }
                if (checker == howMany)
                {
                    Console.WriteLine($"Yes, value={sum2}");
                }
                else
                {
                    Console.WriteLine($"No, maxdiff={max}");
                }
            }
            else
            {
                firstNum = int.Parse(Console.ReadLine());
                secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine($"Yes, value={firstNum + secondNum}");
            }

        }
    }
}
