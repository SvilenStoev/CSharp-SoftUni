using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var myStack = new Stack<string>(input.Reverse());

            while (myStack.Count > 1)
            {
                var firstNumber = int.Parse(myStack.Pop());
                var operation = myStack.Pop();
                var secondNumber = int.Parse(myStack.Pop());

                if (operation == "+")
                {
                    myStack.Push((firstNumber + secondNumber).ToString());
                }
                else if (operation == "-")
                {
                    myStack.Push((firstNumber - secondNumber).ToString());
                }
            }

            Console.WriteLine(myStack.Pop());

        }
    }
}
