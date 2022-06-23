using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodAsterisk : Food
    {
        private const char foodSymbol = '*';
        private const int points = -3;

        public FoodAsterisk(Wall wall)
            : base(wall, foodSymbol, points)
        {

        }

        public override void SetRandomPosition(Queue<Point> snakeElements)
        {
            base.SetRandomPosition(snakeElements);

            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
