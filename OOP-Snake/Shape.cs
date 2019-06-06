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
    }
}
