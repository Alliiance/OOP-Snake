using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class Score
    {
        protected int winWidth;
        protected int winHeight;
        protected static int scorePoints;

        public Score(int winWidth , int winHeight)
        {
            this.winWidth = winWidth;
            this.winHeight = winHeight;
        }

        public void Draw(int posX  ,int score, string text )
        {
             Console.SetCursorPosition(posX, winHeight - 2);
             Console.WriteLine($"{text} {score} points");
        }

        internal void MakeZeroPoints()
        {
            scorePoints = 0;
        }
    }
}
