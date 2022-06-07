using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            string ch1ToString = ch1.ToString();
            string ch2ToString = ch2.ToString();
            string ch3ToString = ch3.ToString();

            string result = ch1ToString + ch2ToString + ch3ToString;
            Console.WriteLine(result);
        }
    }
}
