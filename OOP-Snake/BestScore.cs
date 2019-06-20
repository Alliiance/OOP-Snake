using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class BestScore : Score
    {
        private int winHeight;
        private int winWidth;
        private int bestPoints;
        private string bestScoreText;

        public BestScore(int winHeight, int winWidth, string bestScoreText)
        {
            this.winHeight = winHeight;
            this.winWidth = winWidth;
            this.bestScoreText = bestScoreText;
            Draw(winWidth - 24, winHeight - 2, bestPoints, bestScoreText);
        }
    }
}
