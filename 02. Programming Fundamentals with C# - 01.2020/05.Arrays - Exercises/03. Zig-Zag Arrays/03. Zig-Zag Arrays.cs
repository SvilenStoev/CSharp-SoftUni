using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr2 = new string[n];
            string[] arr3 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] arr1 = Console.ReadLine().Split();

                if (i % 2 == 0)
                {
                    arr2[i] = arr1[0];
                    arr3[i] = arr1[1];
                }
                else
                {
                    arr2[i] = arr1[1];
                    arr3[i] = arr1[0];
                }
            }

            Console.WriteLine(String.Join(" ", arr2));
            Console.WriteLine(String.Join(" ", arr3));
        }
    }
}
