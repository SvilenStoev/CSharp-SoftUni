namespace Recursion
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int result = Pow(2, 3);
            Console.WriteLine(result);
        }

        public static int Pow(int x, int n)
        {
            if (n == 1) 
            {
                return x;
            }

            int resultSoFar = Pow(x, n - 1);

            return x * resultSoFar;
        }
    }
}