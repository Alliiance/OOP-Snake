using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class CreateFood
    {
        int x, y;
        char sym;
        Random rand = new Random();

        public CreateFood(int width, int height, char sym)
        {
            x = width;
            y = height;
            this.sym = sym;
        }

        public Point GetFood()
        {
            int positionX = rand.Next(2, x - 2);
            int positionY = rand.Next(2, y - 2);
            return new Point(positionX, positionY, sym);
        }
    }
}
