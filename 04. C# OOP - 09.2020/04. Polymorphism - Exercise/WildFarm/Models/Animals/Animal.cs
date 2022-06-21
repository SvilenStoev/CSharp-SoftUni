using System;
using System.Collections.Generic;

using WildFarm.Exceptions;
using WildFarm.Models.Foods.Contracts;
using WildFarm.Models.Animals.Contracts;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private const string UneatableFoodMessage = "{0} does not eat {1}!";

        protected Animal(string Name, double weight)
        {
            this.Name = Name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        //Asbtacts because they are different for every type of animal!

        public abstract double WeightMultiplier { get; }

        //List of all foods that are being eaten by this animal!
        public abstract ICollection<Type> PrefferedFoods { get; }

        public void Feed(IFood food)
        {
            if (!this.PrefferedFoods.Contains(food.GetType()))
            {
                string excMsg = string.Format(UneatableFoodMessage, this.GetType().Name, food.GetType().Name);
                 
                throw new UneatableFoodException(excMsg);
            }

            this.Weight += food.Quantity * this.WeightMultiplier;

            this.FoodEaten += food.Quantity;
        }

        public abstract string ProduceSound();
    }
}
