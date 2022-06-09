using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int input1 = int.Parse(Console.ReadLine());
                    int input2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(input1, input2));
                    break;
                case "char":
                    char input3 = char.Parse(Console.ReadLine());
                    char input4 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(input3, input4));
                    break;
                case "string":
                    string input5 = Console.ReadLine();
                    string input6 = Console.ReadLine();
                    Console.WriteLine(GetMax(input5, input6));
                    break;
            }
            
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMax(char num1, char num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static string GetMax(string num1, string num2)
        {
            if (num1.CompareTo(num2)>=0)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

    }
}
