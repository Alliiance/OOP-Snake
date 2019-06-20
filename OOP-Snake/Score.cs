using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class Score
    {
        protected static int scorePoints;
        private int positionX, positionY;
        private int scoreNow, scoreBest;

        public void Draw(int posX ,int posY ,int score, string text )
        {
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine($"{text} {score} points");
        }

    }
}
