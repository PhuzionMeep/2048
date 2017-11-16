using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* CIS 3309
  * PROJECT 3: GAME DESIGN
  * PHU LY AND SANDY YU
  * INSTRUCTOR: FRANK FRIEDMAN
  * */
namespace _2048
{
    class ScoreClass
    {
        
        int score=0;
        int bestScore = 0;

        
        //Constructor. Read best score from file. Reset score.
        
        public ScoreClass()
        {
            readBestScore();
             resetScore();
            //score = 0;
        }

        
       // Get score
        public int getScore()
        {
            return score;
        }
        public void setScore(int score)
        {
            this.score = score;
        }
        
        //Get best score.
        public int getBestScore()
        {
            return bestScore;
        }
        public void setBestScore(int value)
        {
            this.bestScore = value;
        }
        
        //Write best score to text file named scores.txt
        public void writeBestScore()
        {
            using (StreamWriter streamWriter = new StreamWriter("score.txt"))
            {
                streamWriter.Write(bestScore.ToString());
                streamWriter.Flush();
            }
        }

        
        //Read best score from file scores.txt.
        
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

        
       // Check whether score is the best.
        
        public bool isScoreTheBest()
        {
            if (score > bestScore)
            {
                return true;
            }
            return false;
        }

       
        //Set score to 0 (reset).
       
        public void resetScore()
        {
            score = 0;
            
        }

        
        //Set best score to 0 (reset).
        
        public void resetBestScore()
        {
            bestScore = 0;
        }

        public void displayScore(TextBox txt)
        {
            txt.Text = score.ToString();
        }

        
        //display best score value in label.
        
        public void displayBestScore(TextBox txt)
        {
            txt.Text = bestScore.ToString();
        }
    }//end of class
}//end of namespace
