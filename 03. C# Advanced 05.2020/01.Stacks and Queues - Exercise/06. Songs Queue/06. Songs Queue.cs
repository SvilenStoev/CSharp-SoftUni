using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ").ToArray();
            var songsQueue = new Queue<string>(songs);

            while (songsQueue.Any())
            {
                string[] commands = Console.ReadLine().Split(new[] { ' ' }, 2).ToArray();
                string firstCommand = commands[0];

                switch (firstCommand)
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;

                    case "Add":
                        string currSong = commands[1];

                        if (songsQueue.Contains(currSong))
                        {
                            Console.WriteLine($"{currSong} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(currSong);
                        }
                        break;

                    case "Show":

                        Console.WriteLine(string.Join(", ", songsQueue));

                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
