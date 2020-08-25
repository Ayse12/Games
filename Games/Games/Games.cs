using Games.Snake;
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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            frmSnake frm = new frmSnake();
            this.Hide();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Alert!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPuzzle_Click(object sender, EventArgs e)
        {
            frmPuzzle frm = new frmPuzzle();
            this.Hide();
            frm.Show();
        }

        private void btnMaze_Click(object sender, EventArgs e)
        {
            frmMaze frm = new frmMaze();
            this.Hide();
            frm.Show();
        }

        private void btnTicTac_Click(object sender, EventArgs e)
        {
            frmTicTacToe frm = new frmTicTacToe();
            this.Hide();
            frm.Show();
        }

    }
}
