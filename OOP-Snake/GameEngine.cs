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
        private int winWidth, winHeight;

        public GameEngine(int winWidth , int winHeight)
        {
            this.winWidth = winWidth;
            this.winHeight = winHeight;
        }

        internal void Start()
        {
            Walls walls = new Walls(winWidth, winHeight , '*'); // Create walls 
            walls.DrarWalls();

            Point point = new Point(5, 3, '*'); // coordinates of the first point

            Snake snake = new Snake(point, 4, Direction.Right);
            snake.DrawFigere();

            CreateFood createFood = new CreateFood(winWidth, winHeight, '*');
            Point food = createFood.GetFood();
            PlayingScore playingScore = new PlayingScore(winHeight , "You have :");
            BestScore bestScore = new BestScore(winHeight, winWidth, "Best score :");
            food.Draw();

            while (true)
            {
                if (walls.IsWall(snake) || snake.IsRam())
                {
                    break;
                }

                if (snake.IsFood(food))
                {
                    food = createFood.GetFood();
                    food.Draw();
                    playingScore.Add();
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
