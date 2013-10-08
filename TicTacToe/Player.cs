using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Player
    {
        public string myName { get; set; }
        public string myMarker { get; set; }
        public int score { get; set; }

        public Board myBoard {get;set;}

        public Player(Board Board, string Marker, string Name)
        {
            myMarker = Marker;
            myName = Name;
            myBoard = Board;

            myBoard.numberOfSearches = 3;
            myBoard.numberOfMarkers = 2;
        }

        public void printPlayerStats()
        {
            if(myName != null)
                MessageBox.Show(myName + " has a total of " + score.ToString() + " WINS");
        }

        public Board setPlayerMarker(int x, int y)
        {
            myBoard.setMarker(x, y);
            if (myBoard.checkWin())
            {
                score++;
                MessageBox.Show(myName + " HAS WON!!");
            }
            return myBoard;
        }

        public void resetGame()
        {
            myBoard = new Board(3,3);
            myBoard.numberOfSearches = 3;
            myBoard.numberOfMarkers = 2;
        }
    }
}
