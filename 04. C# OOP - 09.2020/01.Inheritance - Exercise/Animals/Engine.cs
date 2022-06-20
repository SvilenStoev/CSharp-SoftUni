using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Animals
{
    public class Engine
    {
        private const string END_OF_INPUT_COMMAND = "Beast!";

        private readonly List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string type = Console.ReadLine();

            while (type != END_OF_INPUT_COMMAND)
            {
                string[] animalDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Animal animal;

                try
                {
                    animal = CreateAnimal(type, animalDetails);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    type = Console.ReadLine();
                    continue;
                }

                this.animals.Add(animal);

                type = Console.ReadLine();
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (var animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal CreateAnimal(string type, string[] animalDetails)
        {
            string currAnimalName = animalDetails[0];
            int currAnimalAge = int.Parse(animalDetails[1]);
            string currAnimalGender = GetGender(animalDetails);

            Animal animal;

            if (type == "Dog")
            {
                animal = new Dog(currAnimalName, currAnimalAge, currAnimalGender);
            }
            else if (type == "Cat")
            {
                animal = new Cat(currAnimalName, currAnimalAge, currAnimalGender);
            }
            else if (type == "Frog")
            {
                animal = new Frog(currAnimalName, currAnimalAge, currAnimalGender);
            }
            else if (type == "Kitten")
            {
                animal = new Kitten(currAnimalName, currAnimalAge);
            }
            else if (type == "Tomcat")
            {
                animal = new Kitten(currAnimalName, currAnimalAge);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }

            return animal;
        }

        private string GetGender(string[] animalDetails)
        {
            string currAnimalGender = null;

            if (animalDetails.Length >= 3)
            {
                currAnimalGender = animalDetails[2];
            }

            return currAnimalGender;
        }
    }
}
