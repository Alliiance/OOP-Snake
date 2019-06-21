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
        private int bestPoints;
        private string bestScoreText;        
        string path = "Score.txt";

        public BestScore(int winWidth, int winHeight ,string bestScoreText) : base(winWidth, winHeight)
        {
            this.bestScoreText = bestScoreText;

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "0");
            }

            using (StreamReader sr = new StreamReader(path))
            {
                bestPoints = Convert.ToInt32(sr.ReadToEnd());
            }
            Draw(winWidth - 24, bestPoints, bestScoreText);

            
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
                    Draw(winWidth - 24, scorePoints, bestScoreText);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);           
            }
        }
    }
}
