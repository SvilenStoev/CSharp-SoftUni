namespace SimpleSnake.GameObjects
{
    using System;
    using System.Collections.Generic;

    public class Wall : Point
    {
        private const char wallSymbol = '\u25A0';

        private int playerPoints = 0;
        private string playerName = "";

        public Wall(int leftX, int topY)
            : base(leftX, topY)
        {
            this.FoodsPointsInfo();
            this.SetPlayerName();
            this.InitializeWallBorders();
            this.PlayerStats();

            Console.SetCursorPosition(this.LeftX + 3, 0);
            Console.WriteLine($"Player username: {this.PlayerName}");
        }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("Username can not be whitespace or less than 3 symbols!");
                }

                this.playerName = value;
            }
        }

        public bool IsPointOfWall(Point snakeHead)
        {
            return snakeHead.LeftX == 0 ||
                   snakeHead.TopY == 0 ||
                   snakeHead.LeftX == this.LeftX - 1 ||
                   snakeHead.TopY == this.TopY;
        }

        private void SetHorizontalLine(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }

        private void SetVerticalLine(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(leftX, topY, wallSymbol);
            }
        }

        private void InitializeWallBorders()
        {
            this.SetHorizontalLine(0);
            this.SetHorizontalLine(this.TopY - 1);

            this.SetVerticalLine(0);
            this.SetVerticalLine(this.LeftX - 1);
        }

        public void AddPoints(Queue<Point> snakeElements)
        {
            this.playerPoints = snakeElements.Count - 6;
        }

        public void PlayerStats()
        {
            Console.SetCursorPosition(this.LeftX + 3, 2);
            Console.WriteLine($" --points: {this.playerPoints}");
            Console.SetCursorPosition(this.LeftX + 3, 3);
            Console.WriteLine($" --level: {(this.playerPoints / 10):f0}");
        }

        public void SetPlayerName()
        {
            Console.Clear();
            Console.SetCursorPosition(this.LeftX + 1, 4);
            Console.Write("Create Username and press enter: ");
            this.PlayerName = Console.ReadLine().ToString();
            Console.Clear();
        }

        public void FoodsPointsInfo()
        {
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Please read the rules first!");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("'#' gives you 1 point when eaten.");
            Console.WriteLine("   '$' gives you 2 points when eaten.");
            Console.WriteLine("   '*' hurts your snake and takes you 3 points.");

            Console.SetCursorPosition(3, 10);
            Console.WriteLine("The game is over if you eat you own body, hit the wall or reach negative points!");

            Console.SetCursorPosition(8, 18);
            Console.Write("Press Enter to continue!");

            ConsoleKeyInfo c;

            do
            {
                Console.SetCursorPosition(10, 20);
                c = Console.ReadKey();
            } while (c.Key != ConsoleKey.Enter);
        }
    }
}
