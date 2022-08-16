namespace SimpleSnake
{
    using System;
    using System.Threading;

    using Utilities;
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            try
            {
                Wall wall = new Wall(60, 20);
                Snake snake = new Snake(wall, 2, 2);

                Engine engine = new Engine(wall, snake);

                engine.Run();
            }
            catch (ArgumentException ae)
            {
                Console.SetCursorPosition(10, 10);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ae.Message);

                //Thread.Sleep(2500);
                Main();
            }
        }
    }
}
