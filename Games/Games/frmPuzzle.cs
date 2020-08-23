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
    public partial class frmPuzzle : Form
    {
        int inNullSliceIndex, moves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        public frmPuzzle()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources.Null });
            lblMove.Text += moves;
            lblTime.Text = "00:00:00";
        }

        private void frmPuzzle_Load(object sender, EventArgs e)
        {
            Shuffle();
        }
        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });//The 8th index belongs to the last piece of the picture. Since we will bring the black screen with null instead of that part, we do not take the 8th index in the list.
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;//Empty picture box index
                }
            } while (CheckWin());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTime.Text != "00:00:00")
                YesOrNo = MessageBox.Show("Are you sure Restart ?", "Cartoon Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesOrNo == DialogResult.Yes || lblTime.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTime.Text = "00:00:00";
                moves = 0;
                lblMove.Text = "Moves : 0";
            }
        }
        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTime.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMove.Text = "Move :" + (++moves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Congratulations ----\nYour Cartoon Is Happy\nTime : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves : " + moves, "Cartoon Puzzle");
                        moves = 0;
                        lblMove.Text = "Moves : 0";
                        lblTime.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                lblTime.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                btnPause.Enabled = false;
            else
                btnPause.Enabled = true;
            if (timer.Elapsed.Minutes.ToString()=="1")
            {
                timer.Reset();
                lblMove.Text = "Moves : 0 ";
                lblTime.Text = "00:00:00";
                moves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Time Is Up\nTry Again","Cartoon Puzzle");
                Shuffle();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text=="Pause")
            {
                timer.Stop();
                gbPuzzleBox.Visible = false;
                btnPause.Text = "Resume";
            }
            else
            {
                timer.Start();
                gbPuzzleBox.Visible = true;
                btnPause.Text = "Pause";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Alert!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        bool CheckWin()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }
    }
}
