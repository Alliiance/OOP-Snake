using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Snake
{
    class PlayingScore : Score
    {

        private string scoreText;

        public PlayingScore (int winWidth, int winHeight, string scoreText) :base (winWidth, winHeight)
        {
            this.scoreText = scoreText;
            Draw(2 , scorePoints , scoreText);
        }


        internal void Add()
        {
            scorePoints += 10;
            Draw(2, scorePoints, scoreText);

        }
    }
}
