using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class Shape
    {
        protected List<Point> figures = new List<Point>();

        public void DrawFigere()
        {
            foreach (var point in figures)
            {
                point.Draw();
            }
        }
        internal bool IsHit(Shape snake)
        {
            foreach (var item in figures)
            {
                if (snake.IsFigure(item))
                    return true;
            }
            return false;
        }

        private bool IsFigure(Point item)
        {
            foreach (var p in figures)
            {
                if (p.IsItPoint(item))
                    return true;
            }
            return false;
        }
    }
}
