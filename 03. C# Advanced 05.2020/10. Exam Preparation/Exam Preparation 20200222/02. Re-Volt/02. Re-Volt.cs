using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int[] playerPosition = new int[2];

            FillMatrix(n, matrix, playerPosition);

            var directions = new Dictionary<string, int[]>()
            {
                ["right"] = new int[] { 0, 1 },
                ["left"] = new int[] { 0, -1 },
                ["up"] = new int[] { -1, 0 },
                ["down"] = new int[] { 1, 0 }
            };

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();
                if (command != "right" && command != "left" && command != "up" && command != "down")
                {
                    continue;
                }

                int[] newPosition = directions[command];

                PlayerOutOfTheRangeCheck(n, playerPosition, newPosition);

                if (matrix[playerPosition[0], playerPosition[1]] == 'T')
                {
                    playerPosition[0] -= newPosition[0];
                    playerPosition[1] -= newPosition[1];
                    continue;
                }
                else if (matrix[playerPosition[0], playerPosition[1]] == 'B')
                {
                    PlayerOutOfTheRangeCheck(n, playerPosition, newPosition);
                }
                else if (matrix[playerPosition[0], playerPosition[1]] == 'F')
                {
                    Console.WriteLine("Player won!");

                    matrix[playerPosition[0], playerPosition[1]] = 'f';

                    break;
                }

                if (i == commandsCount - 1)
                {
                    Console.WriteLine("Player lost!");

                    matrix[playerPosition[0], playerPosition[1]] = 'f';
                }
            }

            PrintMatrix(n, matrix);
        }

        private static void PlayerOutOfTheRangeCheck(int n, int[] playerPosition, int[] newPosition)
        {
            playerPosition[0] += newPosition[0];
            playerPosition[1] += newPosition[1];

            if (playerPosition[0] == n)
            {
                playerPosition[0] = 0;
            }
            else if (playerPosition[0] == -1)
            {
                playerPosition[0] = n - 1;
            }
            else if (playerPosition[1] == n)
            {
                playerPosition[1] = 0;
            }
            else if (playerPosition[1] == -1)
            {
                playerPosition[1] = n - 1;
            }
        }

        private static void PrintMatrix(int n, char[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int n, char[,] matrix, int[] playerPosition)
        {
            for (int row = 0; row < n; row++)
            {
                string currRow = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currRow[col];

                    if (currRow[col] == 'f')
                    {
                        playerPosition[0] = row;
                        playerPosition[1] = col;

                        matrix[row, col] = '-';
                    }

                }
            }
        }
    }