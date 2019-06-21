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

        public Point(Point tail)
        {
            this.x = tail.x;
            this.y = tail.y;
            this.token = tail.token;
        }

        public Point(int x , int y , char token)
        {
            this.x = x;
            this.y = y;
            this.token = token;
        }

        internal void Move(int run, Direction direction)
        {
            if (direction == Direction.Right)
                x += run;
            else if(direction == Direction.Left)
                x -= run;
            else if (direction == Direction.Up)
                y -= run;
            else if (direction == Direction.Down)
                y += run;
        }

        internal void Clear()
        {
            token = ' ';
            Draw();
        }

        internal bool CheckPoint(Point head)
        {
            return x == head.x && y == head.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(token);
        }
    }
}
