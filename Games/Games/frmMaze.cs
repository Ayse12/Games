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
    public partial class frmMaze : Form
    {
        public frmMaze()
        {
            InitializeComponent();
        }

        private void pictureBox27_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You hit the wall. Game Over");
        }

        private void pictureBox29_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("You won the game");
        }
    }
}
