using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class GameEngine
    {
        static Random rand = new Random();

        private Point СreateFood(int x, int y, char sym)
        {
            int positionX = rand.Next(2, x - 2);
            int positionY = rand.Next(2, y - 2);
            return new Point(positionX, positionY, sym);
        }

        private bool GoOnGame()
        {
            Console.SetCursorPosition(winWidth / 2 - 10, winHeight / 2);
            Console.WriteLine("Do you want to continue ? Press yes");

            Console.SetCursorPosition(winWidth / 2 - 10, winHeight / 2 + 2);
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
                return true;
            else
                return false;
        }

        private int winWidth, winHeight;

        public GameEngine(int winWidth , int winHeight)
        {
            this.winWidth = winWidth;
            this.winHeight = winHeight;
        }

        internal void Start()
        {
          
            Walls walls = new Walls(winWidth, winHeight , '*'); 
            walls.DrarWalls();

            Point point = new Point(5, 3, '*'); 

            Snake snake = new Snake(point, 3, Direction.Right);
            snake.DrawFigere();

            Point food = СreateFood(winWidth, winHeight, '*');
            food.Draw();
            Score score = new Score(winHeight, winWidth);
            PlayingScore playingScore = new PlayingScore(winWidth , winHeight, "You have :");
            BestScore bestScore = new BestScore(winWidth, winHeight, "Best score :");

            while (true)
            {
                if (walls.IsWall(snake) || snake.IsLine())
                {
                    if (GoOnGame())
                    {
                        snake.ClearAll(winWidth, winHeight);
                        score.MakeZeroPoints();
                        snake = new Snake(point, 3, Direction.Right);
                        snake.DrawFigere();
                        food = СreateFood(winWidth, winHeight, '*');
                        food.Draw();
                    }
                    else
                    {
                        break;
                    }
                }

                if (snake.IsFood(food))
                {
                    food = СreateFood(winWidth, winHeight, '*');
                    food.Draw();
                    playingScore.Add();
                    bestScore.CheckScore();
                }

                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PutButton(key.Key);
                }
                Thread.Sleep(100);
            }
        }
    }
}
