using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
                //  Задача 3: 
                //Напиши алгоритъм за пресмятане на "забравих им името то математически израз от тип стринг" получен от кантората.Пример "- 1 + 4 - 8/4 * ( 2 + 1)" = - 3

            var input = Console.ReadLine();
            var inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var openParentheses = new Stack<char>();

            bool isBalanced = true;

            foreach (var partString in inputArgs)
            {
                foreach (char c in partString)
                {
                    if (c == '(' || c == '[')
                    {
                        openParentheses.Push(c);
                    }
                    else
                    {
                        if (!openParentheses.Any())
                        {
                            isBalanced = false;
                            break;
                        }

                        char currOpenParenthese = openParentheses.Pop();
                        bool isRoundBalanced = currOpenParenthese == '(' && c == ')';
                        bool isCurlyBalanced = currOpenParenthese == '[' && c == ']';
                        bool isSquareBalanced = currOpenParenthese == '{' && c == '}';

                        if (!(isCurlyBalanced || isRoundBalanced || isSquareBalanced))
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
            }


            if (openParentheses.Any())
            {
                isBalanced = false;
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
