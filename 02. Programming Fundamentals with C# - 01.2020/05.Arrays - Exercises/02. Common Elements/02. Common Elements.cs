using System;

namespace _02._Common_Elements
{
    class Program
    {
        private static object[] commonElements;

        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            string[] commonElements = new string[arr1.Length];
            int counter = 0;

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        commonElements[counter] = arr2[i];
                        counter++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", commonElements));

        }
    }
}
