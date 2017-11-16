using System;
using System.Collections.Generic;
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
{       //Purpose of the board class is to keep track of the board, makes the tiles in the board to move. 
    class BoardClass
    {
        //global attributes
        const int cols = 4;
        const int rows = 4;
        Random rand = new Random();

        public Tile[,] board;
        int newScore = 0;
        private int addNumber = 2;
        private int newX, newY;

        public enum Direction
        {
            eTOP,
            eBOTTOM,
            eLEFT,
            eRIGHT,
        };

        //fill the board with 4 by 4 board with 0s, it creates and instances of tile class
        public void fillBoard()
        {
            for(int i = 0; i < rows;i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    board[i, j] = new Tile();
                }//end of cols
            }//end of  rows
            addRandomTile();
            addRandomTile();
        }//end of fillBoard


        //constructor for the boardClass
        public BoardClass()
        {
            board = new Tile[rows, cols];
            fillBoard();

        }

        //method that adds a random tile value (2 or 4) to the 2D array/on the board 
        public void addRandomTile()
        {
            //Random rand = new Random();

            int row, colum;
            bool notValid = true;
            int value;
            while (notValid)
            {
                row = rand.Next(0, rows);               //generate random Cols and rows
                colum = rand.Next(0, rows);
                if (board[row, colum].getValue() == 0 &&gridEmpty())
                {
                    value = rand.Next(10) < 9 ? 2 : 4;
                    board[row, colum].setValue(value);
                    notValid = false;
                }
            }
        }

        //Check to see if there are move available
        public void MoveAvailable()
        {
            bool result = false;
            for (int i = 0; i < rows; i++)//traverse through the 2D array.
            {
                for (int j = 0; j < cols; j++)
                {
                    //if a 0 is found in the 2D array, we can confirm that the board is indeed empty;
                    //so we set result to true to get out the loop;
                    while (board[i, j].getValue() == 0 && !result)
                    {
                        result = true;
                    }
                }//end of cols
            }//end of  rows
            if (result && abletoMerge()) // display Message to let user know if the board is full with no possible merges 
            {
                MessageBox.Show("NO MORE MOVE AVAILABLE, GAME OVER", "GAME OVER");
                Application.Exit();
            }
        }

        //traverse through the 2D array and compare the cell around the cell to see if there any value match.
        public bool abletoMerge()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {//check to see if there any value match ,if match return true;
                    if (board[j, i] == board[j, i + 1] || board[i, j] ==board[i + 1, j] ||
                        board[j, 3 - i] ==board[j, 2 - i] ||board[3 - i, j] ==board[2 - i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //method to see if the player has reached a 2048 tile
        //if its reach, game is over 
        public Boolean reach2048()
        {
            bool result = false;
            for (int i = 0; i < rows; i++)//traverse through the 2D array.
            {
                for (int j = 0; j < cols; j++)
                {
                    //if 2048 is found in the 2D array
                    //we set result to true to indicate
                    //that a 2048 tile was reached  
                    if (board[i, j].getValue() == 2048 && !result)
                    {
                        result = true;
                    }
                    return result;
                }
            }
            return result;
        }

       //traverses through the 2D array and checks to see if the grid is empty
        public Boolean gridEmpty()
        {
            bool result = false;
            for (int i = 0; i < rows; i++)//traverse through the 2D array.
            {
                for (int j = 0; j < cols; j++)
                {
                    //if a 0 is found in the 2D array, we can confirm that the board is indeed empty;
                    //so we set result to true;
                    while (board[i, j].getValue() == 0 && !result)
                    {
                        result = true;
                        return result;
                    }
                }//end of cols
            }//end of  rows
            return result;
        }

        

        //Moves tiles and merge tiles
        //The algorithm check for if any two tiles depending on the direction click is the same
        //if so, merge it and remove one of the tile.
        public void moveBoard(Direction moveDirection)
        {
            //check to see if the board is full
            if (gridEmpty() == false)
            {
                return;
            }
            Boolean boardAdd = false;
            int maxMergedValue = 2;
            switch (moveDirection)
            {
                //case left
                case Direction.eLEFT:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int k = j + 1; k < 4; k++)
                            {
                                if (board[i, k].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[i, k].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].mergeValue());
                                   board[i, k].removeTile();
                                    boardAdd = true;
                                    newScore += board[i, j].Value;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[i, k].isEmpty())
                                    {
                                        board[i, j].Value = board[i, k].Value;
                                        board[i, k].removeTile();
                                        j--;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                    //case down
                case Direction.eBOTTOM:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 3; i >= 0; i--)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (board[k, j].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[k, j].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].mergeValue());
                                    board[k, j].setMerged(true);
                                    newScore += board[i, j].Value;
                                    
                                    board[k, j].removeTile();
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[k, j].isEmpty())
                                    {
                                        board[i, j].Value = board[k, j].Value;
                                        board[k, j].removeTile();
                                        i++;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                    //case right
                case Direction.eRIGHT:
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 3; j >= 0; j--)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (board[i, k].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[i, k].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].mergeValue());
                                    board[i, k].setMerged(true);
                                    newScore += board[i, j].Value;
                                    board[i, k].removeTile();
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[i, k].isEmpty())
                                    {
                                        board[i, j].Value = board[i, k].Value;
                                        board[i, k].removeTile();
                                        j++;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
                    //case up
                case Direction.eTOP:
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int k = i + 1; k < 4; k++)
                            {
                                if (board[k, j].isEmpty())
                                {
                                    continue;
                                }
                                else if (board[k, j].sameTile(board[i, j]))
                                {
                                    maxMergedValue = Math.Max(maxMergedValue, board[i, j].mergeValue());
                                    board[k, j].setMerged(true);
                                   newScore += board[i, j].Value;
                                    board[k, j].removeTile();
                                    boardAdd = true;
                                    break;
                                }
                                else
                                {
                                    if (board[i, j].isEmpty() && !board[k, j].isEmpty())
                                    {

                                        board[i, j].Value = board[k, j].Value;
                                        board[k, j].removeTile();
                                        i--;
                                        boardAdd = true;
                                        break;
                                    }
                                    else if (!board[i, j].isEmpty())
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    break;
            }

            if (boardAdd)
            {
                this.addRandomTile();
            }
        }
        //a getter for the score 
        public int getScoreValue()
        {
            return newScore;
        }
        //a etter for the score 
        public void setScoreValue(int value)
        {
            this.newScore = value;
        }
    }//end boardClass
}//end Namespace

