using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("./text.txt");
            string[] output = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string currLine = lines[i];

                int lettersCount = CountLetters(currLine);
                int punctMarksCount = CountPunctuationMarks(currLine);

                output[i] = $"Line {i + 1}: {currLine} ({lettersCount})({punctMarksCount})";

                File.WriteAllLines("../../../output.txt", output);
            }


            static int CountLetters(string letters)
            {
                int count = 0;

                for (int i = 0; i < letters.Length; i++)
                {
                    if (Char.IsLetter(letters[i]))
                    {
                        count++;
                    }
                }

                return count;
            }

            static int CountPunctuationMarks(string letters)
            {
                int count = 0;

                for (int i = 0; i < letters.Length; i++)
                {
                    if (Char.IsPunctuation(letters[i]))
                    {
                        count++;
                    }
                }

                return count;
            }
        }
    }
}
