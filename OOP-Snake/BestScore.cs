using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OOP_Snake
{
    class BestScore : Score
    {
        private int winHeight;
        private int winWidth;
        private int bestPoints;
        private string bestScoreText;

        string path = "Score.txt";

        public BestScore(int winHeight, int winWidth, string bestScoreText)
        {
            this.winHeight = winHeight;
            this.winWidth = winWidth;
            this.bestScoreText = bestScoreText;
            using (StreamReader sr = new StreamReader(path))
            {
                bestPoints = Convert.ToInt32(sr.ReadToEnd());
            }
            Draw(winWidth - 24, winHeight - 2, bestPoints, bestScoreText);
        }
        public void CheckScore()
        {
            try
            {

                if (bestPoints < scorePoints)
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(scorePoints);
                    }
                    Draw(winWidth - 24, winHeight - 2, scorePoints, bestScoreText);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);           
            }
        }

    }
}
