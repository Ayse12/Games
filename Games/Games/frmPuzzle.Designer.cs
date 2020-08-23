namespace Games
{
    partial class frmPuzzle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btnShuffle = new System.Windows.Forms.Button();
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.BackColor = System.Drawing.Color.Transparent;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMove.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMove.Location = new System.Drawing.Point(50, 450);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(203, 32);
            this.lblMove.TabIndex = 2;
            this.lblMove.Text = "Moves Made :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTime.Location = new System.Drawing.Point(590, 338);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(270, 69);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPause.Location = new System.Drawing.Point(694, 415);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(91, 48);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuit.Location = new System.Drawing.Point(813, 415);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(91, 48);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 900;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShuffle.Location = new System.Drawing.Point(574, 415);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(91, 48);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.BackgroundImage = global::Games.Properties.Resources.Background;
            this.gbPuzzleBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbPuzzleBox.Controls.Add(this.pb1);
            this.gbPuzzleBox.Controls.Add(this.pb2);
            this.gbPuzzleBox.Controls.Add(this.pb3);
            this.gbPuzzleBox.Controls.Add(this.pb4);
            this.gbPuzzleBox.Controls.Add(this.pb5);
            this.gbPuzzleBox.Controls.Add(this.pb6);
            this.gbPuzzleBox.Controls.Add(this.pb7);
            this.gbPuzzleBox.Controls.Add(this.pb8);
            this.gbPuzzleBox.Controls.Add(this.pb9);
            this.gbPuzzleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPuzzleBox.Location = new System.Drawing.Point(21, 12);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Size = new System.Drawing.Size(531, 427);
            this.gbPuzzleBox.TabIndex = 0;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "PuzzleBox";
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(15, 46);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(166, 121);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(187, 46);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(166, 119);
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(359, 46);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(166, 119);
            this.pb3.TabIndex = 0;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(15, 173);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(166, 119);
            this.pb4.TabIndex = 0;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(187, 171);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(166, 121);
            this.pb5.TabIndex = 0;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(359, 171);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(166, 121);
            this.pb6.TabIndex = 0;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(15, 298);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(166, 118);
            this.pb7.TabIndex = 0;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(187, 298);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(166, 118);
            this.pb8.TabIndex = 0;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pb9
            // 
            this.pb9.Location = new System.Drawing.Point(359, 298);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(166, 118);
            this.pb9.TabIndex = 0;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::Games.Properties.Resources.PuzzlePic;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOriginal.ForeColor = System.Drawing.Color.DarkGreen;
            this.gbOriginal.Location = new System.Drawing.Point(574, 33);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(330, 285);
            this.gbOriginal.TabIndex = 0;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original";
            // 
            // frmPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 491);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.gbPuzzleBox);
            this.Controls.Add(this.gbOriginal);
            this.MaximizeBox = false;
            this.Name = "frmPuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle Game";
            this.Load += new System.EventHandler(this.frmPuzzle_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Timer tmrTime;
    }
}