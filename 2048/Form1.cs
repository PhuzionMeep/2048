using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Form1 : Form
    {
        private BoardClass board;
        public Form1()
        {
            InitializeComponent();
            createBoard();
        }
        private const int maxRows = 4; // Max Rows
        private const int maxCols = 4;// Max Collums
        BoardClass internalboardRep = new BoardClass(); // create the internalBoard Representation of the board.
        private Label[,] newLabel = new Label[maxRows, maxCols];
        ScoreClass score = new ScoreClass();


        //This method is a modified version from the NIM game that generate 16 label dynamicaly;
        // add the label to the panel in a 2D array called newLabel;
        // Display Number in our form.
        private void createBoard()
        {
            pnlBoard.Visible = true;
            Size size = new Size(85, 85);
            Point loc = new Point(0, 0);
            int padding = 10;
            int topMargin = 10;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < maxRows; row++)
            {
                // For each new row, insert at left the Row i label
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 12;
                for (int col = 0; col < maxCols; col++)
                {
                    newLabel[row, col] = new System.Windows.Forms.Label();
                    newLabel[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newLabel[row, col].Size = size;
                    newLabel[row, col].Enabled = false;
                    newLabel[row, col].Visible = true;
                    newLabel[row, col].BackColor = System.Drawing.SystemColors.ScrollBar;
                    newLabel[row, col].Name = "lbl" + row + col;
                    newLabel[row, col].Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    newLabel[row, col].TextAlign = ContentAlignment.MiddleCenter;
                   // newLabel[row, col]
                    pnlBoard.Controls.Add(newLabel[row, col]);
                } // end for col
            } // end for row
        } // end createBoard

        //check to see if the internal Board from the boardClass contain a value in them (since 0 represent that the board is empty)
        //if true, set the text of the label to the value of the board, else leave the label blank.\
        //this will displayed the number needed for the form.
        public void writeBoard()
        {
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    if (internalboardRep.board[row, col].getValue() > 0)
                    {
                        newLabel[row, col].Text = internalboardRep.board[row, col].getValue().ToString();
                    }
                    else
                    {
                        newLabel[row, col].Text = "";
                    }
                }// end for col
            }// end for row
        }//end writeBoard



       
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            writeBoard();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            internalboardRep.MoveAvailable();
            internalboardRep.moveBoard(BoardClass.Direction.eTOP);
            writeBoard();
            txtScore.Text = score.getScore().ToString();
            score.writeScore(txtScore);
            score.writeBestScore(txtBestScore);
            if (score.isScoreTheBest())
            {
                score.writeScore(txtBestScore);
            }


        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            internalboardRep.MoveAvailable();
            internalboardRep.moveBoard(BoardClass.Direction.eRIGHT);
            writeBoard();
            txtScore.Text = score.getScore().ToString();
            score.writeScore(txtScore);
            score.writeBestScore(txtBestScore);
            if (score.isScoreTheBest())
            {
                score.writeScore(txtBestScore);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            internalboardRep.MoveAvailable();
            internalboardRep.moveBoard(BoardClass.Direction.eBOTTOM);
            writeBoard();
            txtScore.Text = score.getScore().ToString();
            score.writeScore(txtScore);
            score.writeBestScore(txtBestScore);
            if (score.isScoreTheBest())
            {
                score.writeScore(txtBestScore);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            internalboardRep.MoveAvailable();
            internalboardRep.moveBoard(BoardClass.Direction.eLEFT);
            //txtScore.Text = score.getScore().ToString();
            writeBoard();
            txtScore.Text = score.getScore().ToString();
            score.writeScore(txtScore);
            score.writeBestScore(txtBestScore);
            if (score.isScoreTheBest())
            {
                score.writeScore(txtBestScore);
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {

            internalboardRep.fillBoard();
            writeBoard();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.W)
            {
                btnUP.PerformClick();
                updateGame();
            }
            if (keyData == Keys.Down || keyData == Keys.S)
            {
                btnDown.PerformClick();
                updateGame();
            }
            if (keyData == Keys.Left || keyData == Keys.A)
            {
                btnLeft.PerformClick();
                updateGame();
            }
            if (keyData == Keys.Right || keyData == Keys.D)
            {
                btnRight.PerformClick();
                updateGame();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void updateGame()
        {
            internalboardRep.Update();
        }
        
    }
}
