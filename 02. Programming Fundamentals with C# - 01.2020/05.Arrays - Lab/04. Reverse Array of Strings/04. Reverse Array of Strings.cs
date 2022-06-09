using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arr = input.Split();


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[arr.Length - i - 1]} ");
            }


        }
    }
}
