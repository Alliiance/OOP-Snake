using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class WallHorizont : Shape
    {
        public WallHorizont(int startWall, int endWall, int y, char token)
        {
            for (int i = startWall; i < endWall; i++)
            {
                Point point = new Point(i , y , token);
                figures.Add(point);
            }
        }
    }
}
