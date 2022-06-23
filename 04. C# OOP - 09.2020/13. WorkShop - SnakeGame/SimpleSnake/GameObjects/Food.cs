using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public abstract class Food : Point
    {
        private readonly char foodSymbol;
        private readonly Wall wall;
        private readonly Random random;

        protected Food(Wall wall, char foodSymbol, int points)
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.FoodPoints = points;
            this.foodSymbol = foodSymbol;
            this.random = new Random();
        }

        public int FoodPoints { get; private set; }

        public virtual void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = this.random.Next(2, this.wall.LeftX - 2);
            this.TopY = this.random.Next(2, this.wall.TopY - 2);

            bool isPointOfSnake = snakeElements.Any(sp => sp.LeftX == this.LeftX && sp.TopY == this.TopY);

            while (isPointOfSnake)
            {
                this.LeftX = this.random.Next(2, this.wall.LeftX - 2);
                this.TopY = this.random.Next(2, this.wall.TopY - 2);

                isPointOfSnake = snakeElements.Any(sp => sp.LeftX == this.LeftX && sp.TopY == this.TopY);
            }
        }

        public bool IsFoodPoint(Point snake)
        {
            return snake.TopY == this.TopY && snake.LeftX == this.LeftX;
        }
    }
}
