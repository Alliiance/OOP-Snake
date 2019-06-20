using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class Walls
    {

        List<Shape> wallList;

        public Walls(int winWidth , int winHeight , char token)
        {
            wallList= new List<Shape>();
            WallHorizont topWall = new WallHorizont(1, winWidth - 1, 1, token);
            WallHorizont botWall = new WallHorizont(1, winWidth - 1, winHeight - 3, token);
            WallVertical leftWall = new WallVertical(1, winHeight - 2, 1, token);
            WallVertical rightWall = new WallVertical(1, winHeight - 2, winWidth - 2, token);


            wallList.Add(topWall);
            wallList.Add(botWall);
            wallList.Add(leftWall);
            wallList.Add(rightWall);
        }

        public void DrarWalls()
        {
            foreach (var wall in wallList)
            {
                wall.DrawFigere();
            }
        }

        public bool IsWall(Snake snake)
        {
            foreach (var item in wallList)
            {
                if (item.IsHit(snake))
                    return true;
            }
            return false;
        }

    }
}
