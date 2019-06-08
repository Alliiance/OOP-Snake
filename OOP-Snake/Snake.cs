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
    }
}
