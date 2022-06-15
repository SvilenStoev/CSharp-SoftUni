using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var myStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];

                if (currSymbol == '(')
                {
                    myStack.Push(i);
                }
                else if (currSymbol == ')')
                {
                    int indexOfOpeningBracket = myStack.Pop();

                    string result = input.Substring(indexOfOpeningBracket, i - indexOfOpeningBracket + 1);

                    Console.WriteLine(result);
                }
            }
        }
    }
}
