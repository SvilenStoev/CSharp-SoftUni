using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пак не можах да я реша сам!

            var input = Console.ReadLine();
            var openParentheses = new Stack<char>();

            bool isBalanced = true;

            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
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
