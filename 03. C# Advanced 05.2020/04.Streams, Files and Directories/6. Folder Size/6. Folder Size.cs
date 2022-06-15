using System;
using System.IO;

namespace _6._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\Movies\A.Star.Is.Born.2018.BDRip.x264.AAC-HUD";

            var files = Directory.GetFiles(path);

            var totalLenght = 0m;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                totalLenght += fileInfo.Length;

                Console.WriteLine($"{fileInfo.Name}");
            }

            Console.WriteLine();

            string text = "The total size of the files is:";

            Console.WriteLine($"{text} {totalLenght:f0} bytes.");
            Console.WriteLine($"{text} {totalLenght / 1024:f0} KB.");
            Console.WriteLine($"{text} {totalLenght / 1024 / 1024:f0} MB.");
            Console.WriteLine($"{text} {totalLenght / 1024 / 1024 / 1024:f2} GB.");

            File.WriteAllText("Text.txt", $"{text} {totalLenght / 1024 / 1024:f0} MB.");
        }
    }
}
