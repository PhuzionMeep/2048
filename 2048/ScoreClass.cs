using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class ScoreClass
    {
        
        int score;
        int bestScore = 0;

        /**
        Constructor. Read best score from file. Reset score.
        */
        public ScoreClass()
        {
            readBestScore();
            resetScore();
        }

        /**
        Get score.
        */
        public int getScore()
        {
            return score;
        }

        /**
        Get best score.
        */
        public int getBestScore()
        {
            return bestScore;
        }

        /**
        Write best score to text file named scores.txt
        */
        public void writeBestScore()
        {
            using (StreamWriter streamWriter = new StreamWriter("score.txt"))
            {
                streamWriter.Write(bestScore.ToString());
                streamWriter.Flush();
            }
        }

        /**
        Read best score from file scores.txt.
        */
        private void readBestScore()
        {
            using (StreamReader read = new StreamReader("score.txt"))
            {
                string textRow = "";
                if (new FileInfo("score.txt").Length > 0)
                {
                    textRow = read.ReadLine();
                    bestScore = int.Parse(textRow);
                }
                else
                {
                    bestScore = 0;
                }
            }
        }

        /**
        Check whether score is the best.
        */
        public bool isScoreTheBest()
        {
            if (score > bestScore)
            {
                return true;
            }
            return false;
        }

        /**
        Set score to 0 (reset).
        */
        public void resetScore()
        {
            score = 0;
        }

        /**
        Set best score to 0 (reset).
        */
        public void resetBestScore()
        {
            bestScore = 0;
        }
    }//end of class
}//end of namespace
