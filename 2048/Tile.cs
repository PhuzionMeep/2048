using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* CIS 3309
  * PROJECT 3: GAME DESIGN
  * PHU LY AND SANDY YU
  * INSTRUCTOR: FRANK FRIEDMAN
  * */

namespace _2048
{
    //The purpose of the Tile Class is To keep track of the tiles
    public class Tile
    {
        private int value;
        private bool merged;
        
        //instantiate tile with a value of zero==empty
        public Tile()
        {
            this.value = 0 ;
        }
        //instantiate tile with a value
        public Tile(int value)
        {
            this.value = value;
        }
        //set the value of the tile
        public void setValue(int value)
        {
            this.value = value;
        }
        //getter to get the value of the tile
        public int getValue()
        {
            return value;
        }
        //if tile equal to other tiles. Make it easier to merge.
        public bool sameTile(Tile tile)
        {
            if (value == tile.value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool equals(Tile otherTile)
        {
            return otherTile.getValue() == this.getValue();
        }

        // * Set the value to zero. In other words, delete / empty the tile.
        // * 
        public void clear()
        {
            this.setValue(0);
        }

        //set the value to the class attributes
        public void setMerged( bool mergeValue)
        {
            this.merged = mergeValue;
        }
        public bool getMerged()
        {
            return merged;
        }
        
        public bool canMergeWith(Tile otherTile)
        {
            return !merged && otherTile != null && !otherTile.merged && value == otherTile.getValue();
            //return true or false. It takes in abother tiles and check to see if the two tiles can be merge. 
            //if so merge it.
            //return false;
        }
        //getter and setter for value
        public int Value
        {
            get { return this.value; }
            set { this.value = value;}
        }
        //checks to see if the tile is empty by seeing if the value is 0
        //empty returns true if the value is 0
        //empty returns false otherwise
        public Boolean isEmpty()
        {
            bool empty = false;
            if (value== 0)
            {
                empty = true;
            }
            return empty;
        }
        //when tile is merged, the value multiplies by 2 to increase the value 
        public int mergeValue()
        {
            value = value * 2 ;
            return value;
        }
        //returns the value, initializes the value to 0 which makes the tile empty
        public int removeTile()
        {
            this.value = 0;
            return value;
        }
    }//end of tileClass
}//end of namespace
