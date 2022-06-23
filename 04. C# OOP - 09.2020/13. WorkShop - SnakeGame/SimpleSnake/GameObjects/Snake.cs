using SimpleSnake.GameObjects.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Snake : Point
    {
        private readonly Queue<Point> snakeQueue;
        private readonly List<Food> food;
        private readonly Wall wall;
        private const char snakeSymbol = '\u25CF';
        private int foodIndex;
        private int nextLeftX;
        private int nextTopY;

        public Snake(Wall wall, int leftX, int topY)
            : base(leftX, topY)
        {
            this.wall = wall;
            this.snakeQueue = new Queue<Point>();
            this.food = new List<Food>();
            this.GetFoods();
            this.foodIndex = RandomFoodNumber;
            this.CreateSnake();
        }

        private int RandomFoodNumber => new Random().Next(0, this.food.Count);

        public bool IsMoving(Point direction)
        {
            Point currSnakeHead = this.snakeQueue.Last();

            this.GetNextPoint(direction, currSnakeHead);

            bool isPointOfSnake = this.snakeQueue.Any(p => p.TopY == this.nextTopY && p.LeftX == this.nextLeftX);

            if (isPointOfSnake)
            {
                return false;
            }

            Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);

            if (this.wall.IsPointOfWall(snakeNewHead))
            {
                return false;
            }

            this.snakeQueue.Enqueue(snakeNewHead);

            snakeNewHead.Draw(snakeSymbol);

            Point snakeTail = this.snakeQueue.Dequeue();
            snakeTail.Draw(' ');

            //TODO Is this correct?

            if (this.food[foodIndex].IsFoodPoint(snakeNewHead))
            {
                this.Eat(direction, currSnakeHead);
            }

            if (this.snakeQueue.Count <= 5)
            {
                return false;
            }

            return true;
        }

        private void Eat(Point direction, Point currSnakeHead)
        {
            int length = this.food[foodIndex].FoodPoints;

            if (length < 0)
            {
                length = Math.Abs(length);

                for (int i = 0; i < length; i++)
                {
                    Point snakeTail = this.snakeQueue.Dequeue();
                    snakeTail.Draw(' ');
                    GetNextPoint(direction, currSnakeHead);
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    this.snakeQueue.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                    GetNextPoint(direction, currSnakeHead);
                }
            }

            this.wall.AddPoints(this.snakeQueue);
            this.wall.PlayerStats();

            this.foodIndex = this.RandomFoodNumber;
            this.food[foodIndex].SetRandomPosition(this.snakeQueue);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }

        private void CreateSnake()
        {
            for (int leftX = 2; leftX <= 7; leftX++)
            {
                this.snakeQueue.Enqueue(new Point(leftX, this.TopY));
                this.snakeQueue.Last().Draw(snakeSymbol);
            }

            this.food[foodIndex].SetRandomPosition(this.snakeQueue);
        }

        private void GetFoods()
        {
            this.food.Add(new FoodHash(this.wall));
            this.food.Add(new FoodDollar(this.wall));
            this.food.Add(new FoodAsterisk(this.wall));
        }
    }
}
