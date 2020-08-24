namespace Games
{
    partial class Games
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Games));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPuzzle = new System.Windows.Forms.Button();
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnMaze = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Snake Game";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Games.Properties.Resources.exit1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(12, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 83);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(247, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Puzzle Game";
            // 
            // btnPuzzle
            // 
            this.btnPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.btnPuzzle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPuzzle.BackgroundImage")));
            this.btnPuzzle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPuzzle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPuzzle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPuzzle.ImageKey = "(none)";
            this.btnPuzzle.Location = new System.Drawing.Point(253, 23);
            this.btnPuzzle.Name = "btnPuzzle";
            this.btnPuzzle.Size = new System.Drawing.Size(193, 173);
            this.btnPuzzle.TabIndex = 8;
            this.btnPuzzle.UseVisualStyleBackColor = false;
            this.btnPuzzle.Click += new System.EventHandler(this.btnPuzzle_Click);
            // 
            // btnSnake
            // 
            this.btnSnake.BackColor = System.Drawing.Color.Transparent;
            this.btnSnake.BackgroundImage = global::Games.Properties.Resources.snake;
            this.btnSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSnake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSnake.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSnake.ImageKey = "(none)";
            this.btnSnake.Location = new System.Drawing.Point(23, 23);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(188, 173);
            this.btnSnake.TabIndex = 1;
            this.btnSnake.UseVisualStyleBackColor = false;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // btnMaze
            // 
            this.btnMaze.BackColor = System.Drawing.Color.Transparent;
            this.btnMaze.BackgroundImage = global::Games.Properties.Resources.maze;
            this.btnMaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaze.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaze.ImageKey = "(none)";
            this.btnMaze.Location = new System.Drawing.Point(483, 23);
            this.btnMaze.Name = "btnMaze";
            this.btnMaze.Size = new System.Drawing.Size(193, 173);
            this.btnMaze.TabIndex = 8;
            this.btnMaze.UseVisualStyleBackColor = false;
            this.btnMaze.Click += new System.EventHandler(this.btnMaze_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(496, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maze Game";
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Games.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 713);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMaze);
            this.Controls.Add(this.btnPuzzle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSnake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Games";
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPuzzle;
        private System.Windows.Forms.Button btnMaze;
        private System.Windows.Forms.Label label3;
    }
}

