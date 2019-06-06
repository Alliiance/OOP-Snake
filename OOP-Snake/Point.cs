using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class Point
    {
        private int x , y;
        private char token;

        public Point(int x , int y , char token)
        {
            this.x = x;
            this.y = y;
            this.token = token;
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(token);
        }

    }
}
