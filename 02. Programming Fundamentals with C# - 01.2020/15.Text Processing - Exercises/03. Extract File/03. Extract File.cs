using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            //string fileName = string.Empty;
            //string fileExtension = string.Empty;
            //int index = 0;

            //for (int i = filePath.Length - 1; i > 0; i--)
            //{
            //    if (filePath[i] == '.')
            //    {
            //        index = i + 1;
            //        fileExtension = filePath.Substring(index);
            //    }
            //    else if (filePath[i] == '\\')
            //    {
            //        fileName = filePath.Substring((i + 1), (index - i - 2));
            //        break;
            //    }
            //}

            string[] pathArgs = filePath.Split('\\').ToArray();

            string fileInfo = pathArgs.Last();
            string fileName = fileInfo.Split('.')[0];
            string fileExtension = fileInfo.Split('.')[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
