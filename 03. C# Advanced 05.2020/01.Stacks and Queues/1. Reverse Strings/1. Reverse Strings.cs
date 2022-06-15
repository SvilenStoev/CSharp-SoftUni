using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myStack = new Stack<char>();

            //string input = Console.ReadLine();

            //foreach (var symbol in input)
            //{
            //    myStack.Push(symbol);
            //}

            //while (myStack.Any())
            //{
            //    Console.Write(myStack.Pop());
            //}

            //Faster way to solve the problem:

            //var myStack = new Stack<char>(Console.ReadLine());

            //while (myStack.Any())
            //{
            //    Console.Write(myStack.Pop());
            //}

            //Fastest way to solve the problem:

            var myStack = new Stack<char>(Console.ReadLine());
            myStack.ToList().ForEach(ch => Console.Write(ch));

            //Console.WriteLine(string.Join(string.Empty, myStack));
        }
    }
}
