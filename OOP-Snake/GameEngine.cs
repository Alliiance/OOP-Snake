using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Console.ReadKey();
        }
    }
}
