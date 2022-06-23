using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodHash : Food
    {
        private const char foodSymbol = '#';
        private const int points = 1;

        public FoodHash(Wall wall)
            : base(wall, foodSymbol, points)
        {

        }

        public override void SetRandomPosition(Queue<Point> snakeElements)
        {
            base.SetRandomPosition(snakeElements);

            Console.BackgroundColor = ConsoleColor.Yellow;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
