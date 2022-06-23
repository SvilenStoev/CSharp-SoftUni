using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
   public class FoodDollar : Food
    {
        private const char foodSymbol = '$';
        private const int points = 2;

        public FoodDollar(Wall wall)
            : base(wall, foodSymbol, points)
        {

        }

        public override void SetRandomPosition(Queue<Point> snakeElements)
        {
            base.SetRandomPosition(snakeElements);

            Console.BackgroundColor = ConsoleColor.Green;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
