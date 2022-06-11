using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_").ToArray(); 
                
                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string finalCommand = Console.ReadLine();

            if (finalCommand == "all")
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
            else
            {
                //1st way to solve the problem:
                for (int i = 0; i < songs.Count; i++)
                {
                    if (songs[i].TypeList == finalCommand)
                    {
                        Console.WriteLine(songs[i].Name);
                    }
                }
            }

            ////2nd way to solve the problem:

            //songs = songs.FindAll(x => x.TypeList == finalCommand);

            //foreach (Song currentSong in songs)
            //{
            //    Console.WriteLine(currentSong.Name);
            //}

            ////3rd way to solve the problem:
            //songs.Where(x => x.TypeList == finalCommand)
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x.Name));

        }
    }
}
