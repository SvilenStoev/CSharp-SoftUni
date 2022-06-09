using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int numberOfRotations = int.Parse(Console.ReadLine());

            numberOfRotations = numberOfRotations % arr.Length;

            for (int c = 0; c < numberOfRotations; c++)
            {
                string temp = arr[0];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                arr[arr.Length - 1] = temp;
            }
            
            Console.WriteLine(String.Join(" ", arr));

        }
    }
}
