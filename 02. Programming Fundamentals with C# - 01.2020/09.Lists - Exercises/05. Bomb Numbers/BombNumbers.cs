using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = bombInfo[0];
            int power = bombInfo[1];

            while (numbers.Contains(bombNumber))
            {
                int indexOfBomb;

                for (int i = 0; i < power; i++)
                {
                    if (numbers.IndexOf(bombNumber) != (numbers.Count - 1))
                    {
                        indexOfBomb = numbers.IndexOf(bombNumber);
                        numbers.RemoveAt(indexOfBomb + 1);
                    }

                    if (numbers.IndexOf(bombNumber) != 0)
                    {
                        indexOfBomb = numbers.IndexOf(bombNumber);
                        numbers.RemoveAt(indexOfBomb - 1);
                    }
                }

                numbers.Remove(bombNumber);
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
