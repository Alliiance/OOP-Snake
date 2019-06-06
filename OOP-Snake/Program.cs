using System;

namespace OOP_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int winWidth =  Console.WindowWidth = 120;
            int winHeight = Console.WindowHeight = 35;
            Console.SetBufferSize(winWidth, winHeight);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.CursorVisible = false;
            Console.Clear();

            GameEngine gameEngine = new GameEngine(winWidth, winHeight);
            gameEngine.Start();

        }
    }
}
