using System;
using System.IO.Compression;

namespace _6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZipFile.CreateFromDirectory("./", @"D:\Programming\SoftUni\3 - C# Advanced and C# OOP - 05.2020/myArchive.zip");
            ZipFile.ExtractToDirectory(@"D:\Programming\SoftUni\3 - C# Advanced and C# OOP - 05.2020/myArchive.zip", @"D:\test");



        }
    }
}
