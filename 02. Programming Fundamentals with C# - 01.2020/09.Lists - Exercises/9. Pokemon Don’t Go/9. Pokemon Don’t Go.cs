using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int index = 0;
            int removedElement = 0;
            int sumOfRemovedElements = 0;

            while (distances.Count != 0)
            {
                index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removedElement = distances[0];
                    sumOfRemovedElements += removedElement;

                    distances.RemoveAt(0);
                    distances.Insert(0, distances[distances.Count - 1]);

                    IncreaseOrDecreaseValue(distances, removedElement);
                }
                else if (index > (distances.Count - 1))
                {
                    removedElement = distances[distances.Count - 1];
                    sumOfRemovedElements += removedElement;

                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(distances[0]);

                    IncreaseOrDecreaseValue(distances, removedElement);
                }
                else
                {
                    removedElement = distances[index];
                    sumOfRemovedElements += removedElement;

                    distances.RemoveAt(index);

                    IncreaseOrDecreaseValue(distances, removedElement);
                }
            }

            Console.WriteLine(sumOfRemovedElements);

        }

        static void IncreaseOrDecreaseValue(List<int> distances, int removedElement)
        {
            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= removedElement)
                {
                    distances[i] += removedElement;
                    continue;
                }

                if (distances[i] > removedElement)
                {
                    distances[i] -= removedElement;
                }
            }
        }
    }
}
