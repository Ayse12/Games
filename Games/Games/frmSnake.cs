using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games.Snake
{
    public partial class frmSnake : Form
    {
        Random rand;
        enum GameBoardFields
        {
            Free,
            Snake,
            Bonus
        };
        enum Directions
        {
            Up,
            Down,
            Left,
            Right
        };
        struct SnakeCoordinates
        {
            public int x;
            public int y;
        }
        GameBoardFields[,] gameBoardFields;
        SnakeCoordinates[] snakeXY;
        int snakeLenght;
        Directions direction;
        Graphics g;
        public frmSnake()
        {
            InitializeComponent();
            gameBoardFields = new GameBoardFields[11, 11];
            snakeXY = new SnakeCoordinates[100];
            rand = new Random();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {
            picBoard.Image = new Bitmap(420, 420);
            g = Graphics.FromImage(picBoard.Image);
            g.Clear(Color.White);
            for (int i = 0; i <= 10; i++)
            {
                //top and button walls
                g.DrawImage(imgList.Images[6], i * 35, 0);
                g.DrawImage(imgList.Images[6], i * 35, 385);
            }
            for (int i = 0; i <= 11; i++)
            {
                //left and right walls
                g.DrawImage(imgList.Images[6], 0, i * 35);
                g.DrawImage(imgList.Images[6], 385, i * 35);
            }

            //initial snake body and head
            snakeXY[0].x = 5;//Head
            snakeXY[0].y = 5;
            snakeXY[1].x = 5;//Head
            snakeXY[1].y = 6;
            snakeXY[2].x = 5;//Head
            snakeXY[2].y = 7;

            g.DrawImage(imgList.Images[5], 5 * 35, 5 * 35);//Head
            g.DrawImage(imgList.Images[4], 5 * 35, 6 * 35);//First part of body
            g.DrawImage(imgList.Images[4], 5 * 35, 7 * 35);//Second part of body

            gameBoardFields[5, 5] = GameBoardFields.Snake;
            gameBoardFields[5, 6] = GameBoardFields.Snake;
            gameBoardFields[5, 7] = GameBoardFields.Snake;

            direction = Directions.Up;
            snakeLenght = 3;
            for (int i = 0; i < 4; i++)
            {
                Bonus();
            }
        }
        private void Bonus()
        {
            int x, y;
            var imgIndex = rand.Next(0, 4);
            do
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
            } while (gameBoardFields[x, y] != GameBoardFields.Free);

            gameBoardFields[x, y] = GameBoardFields.Bonus;
            g.DrawImage(imgList.Images[imgIndex], x * 35, y * 35);
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    direction = Directions.Up;
                    break;
                case Keys.Down:
                    direction = Directions.Down;
                    break;
                case Keys.Left:
                    direction = Directions.Left;
                    break;
                case Keys.Right:
                    direction = Directions.Right;
                    break;
            }
        }
        private void GameOver()
        {
            timer.Enabled = false;
            MessageBox.Show("GAME OVER");
        }
    }
}
