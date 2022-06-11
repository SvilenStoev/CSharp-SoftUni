using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.__SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSchedule = Console.ReadLine().Split(", ").ToList();

            string input;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(":").ToArray();
                string currCommand = commands[0];
                string lessonTitle = commands[1];

                switch (currCommand)
                {
                    case "Add":

                        if (!initialSchedule.Contains(lessonTitle))
                        {
                            initialSchedule.Add(lessonTitle);
                        }
                        break;

                    case "Insert":

                        if (!initialSchedule.Contains(lessonTitle))
                        {
                            initialSchedule.Insert(int.Parse(commands[2]), lessonTitle);
                        }
                        break;

                    case "Remove":

                        if (initialSchedule.Contains(lessonTitle))
                        {
                            initialSchedule.Remove(lessonTitle);

                            if (initialSchedule.Contains(lessonTitle + "-Exercise"))
                            {
                                initialSchedule.Remove(lessonTitle + "-Exercise");
                            }

                        }
                        break;

                    case "Swap":
                        string lessonTitle2 = commands[2];

                        if (initialSchedule.Contains(lessonTitle) && initialSchedule.Contains(lessonTitle2))
                        {
                            int indexOflessonTitle = initialSchedule.IndexOf(lessonTitle);
                            int indexOflessonTitle2 = initialSchedule.IndexOf(lessonTitle2);

                            initialSchedule[indexOflessonTitle] = lessonTitle2;
                            initialSchedule[indexOflessonTitle2] = lessonTitle;

                            if (initialSchedule.Contains(lessonTitle + "-Exercise") && initialSchedule.Contains(lessonTitle2 + "-Exercise"))
                            {
                                initialSchedule[indexOflessonTitle + 1] = lessonTitle2 + "-Exercise";
                                initialSchedule[indexOflessonTitle2 + 1] = lessonTitle + "-Exercise";
                            }
                            else if (initialSchedule.Contains(lessonTitle + "-Exercise"))
                            {
                                initialSchedule.Insert(indexOflessonTitle2 + 1, lessonTitle + "-Exercise");
                                initialSchedule.RemoveAt(indexOflessonTitle + 2);
                            }
                            else if (initialSchedule.Contains(lessonTitle2 + "-Exercise"))
                            {
                                initialSchedule.Insert(indexOflessonTitle + 1, lessonTitle2 + "-Exercise");
                                initialSchedule.RemoveAt(indexOflessonTitle2 + 2);
                            }
                        }
                        break;

                    case "Exercise":
                        string exercise = lessonTitle + "-Exercise";

                        if (initialSchedule.Contains(lessonTitle) && !initialSchedule.Contains(exercise))
                        {
                            initialSchedule.Insert((initialSchedule.IndexOf(lessonTitle) + 1), exercise);
                        }
                        else if (!initialSchedule.Contains(lessonTitle))
                        {
                            initialSchedule.Add(lessonTitle);
                            initialSchedule.Add(exercise);
                        }
                        break;
                }
            }

            for (int i = 0; i < initialSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{initialSchedule[i]}");
            }

        }
    }
}
