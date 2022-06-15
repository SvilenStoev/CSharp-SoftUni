using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] array = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                array[row] = currRow;
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "END")
                {
                    break;
                }

                string currCommand = commands[0];
                int currRow = int.Parse(commands[1]);
                int currCol = int.Parse(commands[2]);
                int currValue = int.Parse(commands[3]);

                if (!(currRow >= 0 && currRow < rows && currCol >= 0 && currCol < array[currRow].Length))
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (currCommand)
                {
                    case "Add":

                        array[currRow][currCol] += currValue;

                        break;

                    case "Subtract":

                        array[currRow][currCol] -= currValue;

                        break;
                }
            }

            foreach (int[] currArray in array)
            {
                Console.WriteLine(string.Join(" ", currArray));
            }
        }
    }
}
