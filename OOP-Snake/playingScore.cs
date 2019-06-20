using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class PlayingScore : Score
    {
        private int winHeight;
        private int scorePoints;
        private string scoreText;

        public PlayingScore(int winHeight , string scoreText)
        {
            this.winHeight = winHeight;
            this.scoreText = scoreText;
            Draw(2 , winHeight - 2, scorePoints , scoreText);
        }


        internal void Add()
        {
            scorePoints += 10;
            Draw(2, winHeight - 2, scorePoints, scoreText);
        }
    }
}
