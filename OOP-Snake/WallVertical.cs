using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class WallVertical : Shape
    {
        public WallVertical(int startWall, int endWall, int y, char token)
        {
            for (int i = startWall; i < endWall; i++)
            {
                Point point = new Point(y, i, token);
                figures.Add(point);
            }
        }
    }
}
