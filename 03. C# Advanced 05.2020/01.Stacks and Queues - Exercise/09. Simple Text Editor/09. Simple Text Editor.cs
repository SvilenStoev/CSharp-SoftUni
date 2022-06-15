using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split().ToArray();
                int command = int.Parse(commands[0]);

                switch (command)
                {
                    case 1:

                        char[] charsToAppend = commands[1].Split().Select(char.Parse).ToArray();

                        for (int j = 0; j < charsToAppend.Length; j++)
                        {
                            stack.Push(charsToAppend[j]);
                        }

                        break;

                    case 2:

                        int count = int.Parse(commands[1]);

                        for (int k = 0; k < count; k++)
                        {
                            stack.Pop();
                        }

                        break;

                    case 3:

                        int position = int.Parse(commands[1]);
                        string text = stack.ToString();

                        Console.WriteLine(text[position - 1]);

                        break;

                    case 4:



                        break;

                }

            }







        }
    }
}
