using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }
        int count = 0; //to count the number of turn
        void restartGame()
        {
            frmTicTacToe frm = new frmTicTacToe();
            this.Close();
            frm.Show();
        }
        void syybol(object sendero)
        {
            string buttontxt = ((Button)sendero).Text;
            if (buttontxt == "")
            {
                if (count % 2 == 0)
                    ((Button)sendero).Text = "O";
                else
                    ((Button)sendero).Text = "X";
                count++;//It will increment count which turn to next player
                checkWin("O");
                checkWin("X");
            }
            else
            {
                MessageBox.Show("Invalid click");
            }
        }
        void checkWin(string symbol)
        {
            if (button1.Text==symbol && button2.Text==symbol && button3.Text==symbol)
            {
                MessageBox.Show(symbol +" " + "Won Game");
                restartGame();
            }
            else
            {
                if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol)
                {
                    MessageBox.Show(symbol + " " + "Won Game");
                    restartGame();
                }
                else if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol)
                {
                    MessageBox.Show(symbol + " " + "Won Game");
                    restartGame();
                }
                else if (button9.Text == symbol && button6.Text == symbol && button3.Text == symbol)
                {
                    MessageBox.Show(symbol + " " + "Won Game");
                    restartGame();
                }
                else if (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol)
                {
                    MessageBox.Show(symbol + " " + "Won Game");
                    restartGame();
                }
                else if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol)
                {
                    MessageBox.Show(symbol + " " + "Won Game");
                    restartGame();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            syybol(sender);
        }
    }
}
