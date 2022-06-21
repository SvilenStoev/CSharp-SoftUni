using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public IFood ProduceFood(string type, int quantity)
        {
            IFood food = null;

            switch (type)
            {
                case "Vegetable":

                    food = new Vegetable(quantity);

                    break;

                case "Fruit":

                    food = new Fruit(quantity);

                    break;

                case "Meat":

                    food = new Meat(quantity);

                    break;

                case "Seeds":

                    food = new Seeds(quantity);

                    break;
            }

            return food;
        }
    }
}
