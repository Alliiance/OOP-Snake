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
            Point point = new Point(5, 3, '*'); // coordinates of the first point
            point.Draw();

            Console.ReadKey();
        }
    }
}
