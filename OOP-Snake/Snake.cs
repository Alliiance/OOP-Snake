using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class Snake : Shape
    {
        Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                figures.Add(p);
            }
        }

        internal void Move()
        {
            Point first = figures.First();
            figures.Remove(first);
            Point nextPoint = GetNextPoint();
            figures.Add(nextPoint);
            nextPoint.Draw();
            first.Clear();
        }

        private Point GetNextPoint()
        {
            Point point = figures.Last();
            Point nextPoint = new Point(point);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal void PutButton(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
        }

        internal bool IsLine()
        {
            for (int i = 0; i < figures.Count - 2; i++)
            {
                Point head = figures.Last();
                if (head.IsItPoint(figures[i]))
                {
                    return true;
                }
            }
            return false;
        }

        internal bool IsFood(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsItPoint(food))
            {
                figures.Add(head);
                return true;

            }
            return false;
        }
    }
}
