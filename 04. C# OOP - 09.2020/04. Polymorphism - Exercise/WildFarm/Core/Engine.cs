using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Core.Contracts;
using WildFarm.Exceptions;
using WildFarm.Factories;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<IAnimal> animals;
        private FoodFactory foodFactory;

        public Engine()
        {
            this.animals = new List<IAnimal>();
            this.foodFactory = new FoodFactory();
        }

        public void Run()
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] foodArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                IAnimal animal = ProduceAnimal(animalArgs);

                string foodType = foodArgs[0];
                int foodQuantity = int.Parse(foodArgs[1]);
                IFood food = this.foodFactory.ProduceFood(foodType, foodQuantity);

                this.animals.Add(animal);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Feed(food);
                }
                catch (UneatableFoodException ufe)
                {
                    Console.WriteLine(ufe.Message);
                }
            }

            foreach (var animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IAnimal ProduceAnimal(string[] animalArgs)
        {
            IAnimal animal = null;

            string animalType = animalArgs[0];
            string animalName = animalArgs[1];
            double animalWeight = double.Parse(animalArgs[2]);

            switch (animalType)
            {
                case "Owl":

                    double wingSize = double.Parse(animalArgs[3]);

                    animal = new Owl(animalName, animalWeight, wingSize);

                    break;

                case "Hen":

                    wingSize = double.Parse(animalArgs[3]);

                    animal = new Hen(animalName, animalWeight, wingSize);

                    break;

                case "Mouse":

                    string livingRegion = animalArgs[3];

                    animal = new Mouse(animalName, animalWeight, livingRegion);

                    break;

                case "Dog":

                    livingRegion = animalArgs[3];

                    animal = new Dog(animalName, animalWeight, livingRegion);

                    break;

                case "Cat":

                    livingRegion = animalArgs[3];
                    string breed = animalArgs[4];

                    animal = new Cat(animalName, animalWeight, livingRegion, breed);

                    break;

                case "Tiger":

                    livingRegion = animalArgs[3];
                    breed = animalArgs[4];

                    animal = new Tiger(animalName, animalWeight, livingRegion, breed);

                    break;
            }

            return animal;
        }

    }
}
