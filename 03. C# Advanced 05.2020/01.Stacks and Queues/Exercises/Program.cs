using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = RemoveWhitespace(Console.ReadLine());

            var myStack = new Stack<int>();
            int removedCharsCount = 0;
            double result = 0.0;

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

                    string stringResult = input.Substring(indexOfOpeningBracket, i - indexOfOpeningBracket + 1);

                    Console.WriteLine($"Calculate first: {stringResult}");

                    for (int j = 0; j < stringResult.Length; j++)
                    {
                        char ch = stringResult[j];
                        double currResult = 0.0;

                        if (double.TryParse(ch.ToString(), out double parseResult))
                        {
                            try
                            {
                                if (stringResult[j - 1] == '-')
                                {
                                    parseResult = -parseResult;
                                }
                            }
                            catch (Exception)
                            {
                                throw new ArgumentOutOfRangeException("Svilen you are an idiot!");
                            }

                            bool isSecondNumberParsable = double.TryParse(stringResult[j + 2].ToString(), out double parseSecondNumber);

                            if (stringResult[j + 1] == '-' && isSecondNumberParsable)
                            {
                                currResult = parseResult - parseSecondNumber;
                            }
                            else if (stringResult[j + 1] == '+')
                            {
                                currResult = parseResult + parseSecondNumber;
                            }
                            else if (stringResult[j + 1] == '*')
                            {
                                currResult = parseResult * parseSecondNumber;
                            }
                            else if (stringResult[j + 1] == '/')
                            {
                                currResult = parseResult / parseSecondNumber;
                            }

                            Console.WriteLine($"Current result: {currResult}");

                            if (currResult != 0.0)
                            {
                                input = input.Replace(stringResult, currResult.ToString());

                                removedCharsCount += stringResult.Length - 1;
                                i -= stringResult.Length;

                                Console.WriteLine();
                                Console.WriteLine($"Remaining for calculation: {input}");
                                result = currResult;

                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"The final result is: {result:f2}");
        }

        public static string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
