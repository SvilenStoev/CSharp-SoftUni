using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleSnake.Core
{
    public class Engine
    {
        private readonly List<Point> pointsOfDirection;
        private Direction direction;
        private readonly Snake snake;
        private readonly Wall wall;
        private double sleepTime;

        public Engine(Wall wall, Snake snake)
        {
            this.snake = snake;
            this.wall = wall;
            this.sleepTime = 100;
            this.pointsOfDirection = new List<Point>();
        }

        public void Run()
        {
            this.CreateDirections();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    GetNextDirection();
                }

                bool isMoving = snake.IsMoving(this.pointsOfDirection[(int)direction]);

                if (!isMoving)
                {
                    AskUserForRestart();
                }

                this.sleepTime -= 0.01;

                if (this.direction == Direction.Left || this.direction == Direction.Right)
                {
                    Thread.Sleep((int)this.sleepTime);
                }
                else
                {
                    Thread.Sleep((int)this.sleepTime + 30);
                }

            }
        }

        private void AskUserForRestart()
        {
            int leftX = this.wall.LeftX + 2;
            int topY = 6;

            Console.SetCursorPosition(leftX, topY);

            Console.Write("Would you like to start new game? y/n");
            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
            {
                Console.Clear();
                StartUp.Main();
            }
            else if (input.Key == ConsoleKey.N)
            {
                StopGame();
            }
            else
            {
                Console.WriteLine("Please press valid key!");
                this.AskUserForRestart();
            }
        }

        private void StopGame()
        {
            Console.Clear();
            Console.SetCursorPosition(20, 10);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Game over!");
            Console.WriteLine();
            Environment.Exit(0);
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.RightArrow)
            {
                if (this.direction != Direction.Left)
                {
                    this.direction = Direction.Right;
                }
            }
            else if (input.Key == ConsoleKey.LeftArrow)
            {
                if (this.direction != Direction.Right)
                {
                    this.direction = Direction.Left;
                }
            }
            else if (input.Key == ConsoleKey.DownArrow)
            {
                if (this.direction != Direction.Up)
                {
                    this.direction = Direction.Down;
                }
            }
            else if (input.Key == ConsoleKey.UpArrow)
            {
                if (this.direction != Direction.Down)
                {
                    this.direction = Direction.Up;
                }
            }

            Console.CursorVisible = false;
        }

        private void CreateDirections()
        {
            this.pointsOfDirection.Add(new Point(1, 0));
            this.pointsOfDirection.Add(new Point(-1, 0));
            this.pointsOfDirection.Add(new Point(0, 1));
            this.pointsOfDirection.Add(new Point(0, -1));
        }
    }
}
