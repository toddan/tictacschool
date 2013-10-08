using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Board
    {
        public bool[,] area { get; set; }
        public bool win { get; set; }
        public int numberOfSearches { get; set; }
        public int numberOfMarkers { get; set; }

        public Board(int x, int y)
        {
            area = new bool[x, y];
            win = false;
        }

        public void setMarker(int x, int y)
        {
            area[x, y] = true;
        }

        /// <summary>
        /// Algorithm to calculate who is the winner.
        /// 
        /// We look thru each coordinate and then count three steps forward.
        /// If there is three boolean true in a coordinate the player has won. 
        /// </summary>
        public bool checkWin()
        {
            for (int i = 0; i < numberOfSearches; i++)
            {
                // if the player has won. Break the loop and tell the victory to the player. 
                if (win == true)
                {
                    return win;
                }

                for (int j = 0; j < numberOfSearches; j++)
                {
                    // if a coordinate is true start to count neighbours. 
                    if (area[i, j])
                    {
                        // check horisontal 
                        for (int x = 0; x < numberOfSearches; x++)
                        {
                            // if there is not three trues from the coordinate. Break the loop.
                            if (area[i, x] != true)
                                break;

                            // If there is three trues in the game area starting from 0 to 2, make the player a winner. 
                            if (x == numberOfMarkers)
                            {
                                win = true;
                            }
                        }

                        // check vertical
                        for (int x = 0; x < numberOfSearches; x++)
                        {
                            if (area[x, j] != true)
                                break;
                            if (x == numberOfMarkers)
                            {
                                win = true;
                            }
                        }

                        // check diagonal
                        if (i == j)
                        {
                            for (int x = 0; x < numberOfSearches; x++)
                            {
                                if (area[x, x] != true)
                                    break;
                                if (x == numberOfMarkers)
                                {
                                    win = true;
                                }
                            }
                        }

                        // check opposite diagonal
                        for (int x = 0; x < numberOfSearches; x++)
                        {
                            if (area[x, numberOfMarkers - x] != true)
                                break;
                            if (x == numberOfMarkers)
                            {
                                win = true;
                            }
                        }
                    }
                }
            }
            return win;
        }
    }
}