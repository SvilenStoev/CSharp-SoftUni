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
        private readonly List<Food> bombs;
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
            this.bombs = new List<Food>();
            this.GetFoods();
            this.foodIndex = 0;
            this.CreateSnake();
        }

        private int RandomFoodNumber => new Random().Next(0, 100);

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
            this.bombs.ForEach(b =>
            {
                if (b.HasFoodPointCollision(snakeNewHead))
                {
                    this.Eat(direction, currSnakeHead, b);
                    return;
                }
            });

            if (this.food[this.foodIndex].HasFoodPointCollision(snakeNewHead))
            {
                this.Eat(direction, currSnakeHead);
            }

            if (this.snakeQueue.Count <= 5)
            {
                return false;
            }

            return true;
        }

        private void Eat(Point direction, Point currSnakeHead, Food bomb = null)
        {
            int length;

            if (bomb == null)
            {
                length = this.food[foodIndex].FoodPoints;
            }
            else
            {
                length = bomb.FoodPoints;
                this.bombs.Remove(bomb);
            }

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

            int randomNumber = this.RandomFoodNumber;

            if (randomNumber <= 45)
            {
                this.DrawFoodOnRandomPosition(0);
            }
            else if (randomNumber <= 75)
            {
                this.DrawFoodOnRandomPosition(1);
            }
            else
            {
                if (length >= 0)
                {
                    this.DrawBombOnRandomPosition();
                }
                this.DrawFoodOnRandomPosition(0);
            }
        }

        private void DrawFoodOnRandomPosition(int foodIndex)
        {
            this.foodIndex = foodIndex;
            this.food[this.foodIndex].SetRandomPosition(this.snakeQueue);
            this.food[this.foodIndex].DrawFood();
        }

        private void DrawBombOnRandomPosition()
        {
            int nextBombIndex = this.bombs.Count;

            this.bombs.Add(new FoodAsterisk(this.wall));
            this.bombs[nextBombIndex].SetRandomPosition(this.snakeQueue);
            this.bombs[nextBombIndex].DrawFood();
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

            this.food[0].SetRandomPosition(this.snakeQueue);
            this.food[0].DrawFood();
        }

        private void GetFoods()
        {
            this.food.Add(new FoodHash(this.wall));
            this.food.Add(new FoodDollar(this.wall));
        }
    }
}
