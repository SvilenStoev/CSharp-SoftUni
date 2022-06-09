using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            PrintVowelsCount(input);
        }

        static void PrintVowelsCount(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'o' || 
                    text[i] == 'e' || text[i] == 'i' || 
                    text[i] == 'u' || text[i] == 'y')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
