using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Ai
    {
        private Board myBoard { get; set; }

        private List<int[]> preferredMoves = new List<int[]>(){
         new int[]{1, 1}, new int[]{0, 0}, new int[]{0, 2}, new int[]{2, 0}, new int[]{2, 2},
         new int[]{0, 1}, new int[]{1, 0}, new int[]{1, 2}, new int[]{2, 1}};

        public Ai()
        {
            myBoard = new Board(3, 3);
            myBoard.numberOfSearches = 3;
            myBoard.numberOfMarkers = 2;
        }

        public void play(Board playerBoard)
        {
            foreach (var move in preferredMoves)
            {
                if (!playerBoard.area[move[0],move[1]])
                {
                    preferredMoves.Remove(move);
                    myBoard.setMarker(move[0], move[1]);
                    setMarker(move[0], move[1]);
                    if (myBoard.checkWin())
                    {
                        MessageBox.Show("COMPUTER HAS WON!!");
                    }
                    break;
                }
            }
        }

        private void setMarker(int x,int y)
        {
            TicTacToe.tictactoeRef.BeginInvoke(new Action(delegate()
                {
                    if (x == 0 && y == 0)
                        TicTacToe.button1Ref.Text = "X";
                    else if (x == 0 && y == 1)
                        TicTacToe.button2Ref.Text = "X";
                    else if (x == 0 && y == 2)
                        TicTacToe.button3Ref.Text = "X";
                    else if (x == 1 && y == 0)
                        TicTacToe.button4Ref.Text = "X";
                    else if (x == 1 && y == 1)
                        TicTacToe.button5Ref.Text = "X";
                    else if (x == 1 && y == 2)
                        TicTacToe.button6Ref.Text = "X";
                    else if (x == 2 && y == 0)
                        TicTacToe.button7Ref.Text = "X";
                    else if (x == 2 && y == 1)
                        TicTacToe.button8Ref.Text = "X";
                    else if (x == 2 && y == 2)
                        TicTacToe.button9Ref.Text = "X";
                }));
        }

    }
}
