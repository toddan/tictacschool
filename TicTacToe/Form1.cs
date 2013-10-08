using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private bool turn = true;
        private bool computer = false;

        private Player player1;
        private Player player2;

        private Ai aiPlayer;

        public static TicTacToe tictactoeRef;

        public static Button button1Ref;
        public static Button button2Ref;
        public static Button button3Ref;
        public static Button button4Ref;
        public static Button button5Ref;
        public static Button button6Ref;
        public static Button button7Ref;
        public static Button button8Ref;
        public static Button button9Ref;

        public TicTacToe()
        {
            InitializeComponent();
            tictactoeRef = this;
            button1Ref = button1;
            button2Ref = button2;
            button3Ref = button3;
            button4Ref = button4;
            button5Ref = button5;
            button6Ref = button6;
            button7Ref = button7;
            button8Ref = button8;
            button9Ref = button9;

        }

        private string setHumanMarker(int x, int y)
        {
            if (turn)
            {
                player1.setPlayerMarker(x, y);
                labelPlayer.Text = player2.myName;
                turn = false;
                return player1.myMarker;
            }
            else
            {
                player2.setPlayerMarker(x, y);
                labelPlayer.Text = player1.myName;
                turn = true;
                return player2.myMarker;
            }
        }

        private string setComputerMarker(int x, int y)
        {
            player1.setPlayerMarker(x, y);
            aiPlayer.play(player1.myBoard);
            return player1.myMarker;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button1.Text = setComputerMarker(0, 0);
            }
            else
            {
                button1.Text = setHumanMarker(0, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button2.Text = setComputerMarker(0, 1);
            }
            else
            {
                button2.Text = setHumanMarker(0, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button3.Text = setComputerMarker(0, 2);
            }
            else
            {
                button3.Text = setHumanMarker(0, 2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button4.Text = setComputerMarker(1, 0);
            }
            else
            {
                button4.Text = setHumanMarker(1, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button5.Text = setComputerMarker(1, 1);
            }
            else
            {
                button5.Text = setHumanMarker(1, 1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button6.Text = setComputerMarker(1, 2);
            }
            else
            {
                button6.Text = setHumanMarker(1, 2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button7.Text = setComputerMarker(2, 0);
            }
            else
            {
                button7.Text = setHumanMarker(2, 0);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button8.Text = setComputerMarker(2, 1);
            }
            else
            {
                button8.Text = setHumanMarker(2, 1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (computer)
            {
                button9.Text = setComputerMarker(2, 2);
            }
            else
            {
                button9.Text = setHumanMarker(2, 2);
            }
        }

        private void createHumanPlayers()
        {
            string player1Name = "";
            string player2Name = "";

            string Player1 = "";
            string Player2 = "";

            if (NameDialog.InputBox(ref player1Name, ref player2Name) == DialogResult.OK)
            {
                Player1 = player1Name;
                Player2 = player2Name;
            }
            else
            {
                MessageBox.Show("I dont like you anyway!");
                this.Close();
            }

            player1 = new Player(new Board(3, 3), "O", Player1);
            player2 = new Player(new Board(3, 3), "X", Player2);

            if (Player2 == "computer")
            {
                computer = true;
                aiPlayer = new Ai();
            }
            labelPlayer.Text = player1.myName;
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1.resetGame();
            player2.resetGame();

            //reset all the buttons
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Text = "";
            }

            createHumanPlayers();
        }

        private void playerStatsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            player1.printPlayerStats();
            player2.printPlayerStats();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createHumanPlayers();
            playerToolStripMenuItem.Enabled = true;
            restartGameToolStripMenuItem.Enabled = true;

            foreach (Button btn in this.Controls.OfType<Button>())
                btn.Enabled = true;
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to play against the computer, write computer in the player2 textbox");
        }
    }
}
