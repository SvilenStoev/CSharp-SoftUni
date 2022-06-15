using System;
using System.IO;

namespace _99._Print_Directory_and_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Movies";            

            PrintDirectoryAndFiles(path, string.Empty);

        }

        static void PrintDirectoryAndFiles(string path, string prefix)
        {
            var directories = Directory.GetDirectories(path);

            var directoryInfo = new DirectoryInfo(path);

            Console.WriteLine($"{prefix} Dir: {directoryInfo.Name}");

            foreach (var directory in directories)
            {
                PrintDirectoryAndFiles(directory, prefix += "--");
            }

            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                Console.WriteLine($"{prefix} File: {fileInfo.Name}");
            }
        }
    }
}
