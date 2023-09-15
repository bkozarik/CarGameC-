using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CarGame1
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose = false;
        private int countCoins = 0;

        public Form1()
        {
            InitializeComponent();

            bg1.MouseDown += MouseCLickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseCLickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;
        }

        private void MouseCLickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + bg1.Top);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 7;
            bg1.Top += speed;
            bg2.Top += speed;

            int carSpeedRight = 5;
            int carSpeedLeft = 15;

            enemy1.Top += carSpeedLeft;
            enemy2.Top += carSpeedLeft;
            enemy3.Top += carSpeedRight;
            enemy4.Top += carSpeedRight;

            coin.Top += speed;



            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg2.Top = -630;
            }

            Random rand = new Random(); // Create a single Random instance

            if (coin.Top >= 650)
            {
                coin.Top = -50;
                coin.Left = rand.Next(150, 560);
            }

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -130;
                enemy1.Left = GenerateRandomPosition(25, 370, enemy2, enemy3, enemy4, coin);
            }

            if (enemy2.Top >= 650)
            {
                enemy2.Top = -400;
                enemy2.Left = GenerateRandomPosition(25, 370, enemy1, enemy3, enemy4, coin);
            }

            if (enemy3.Top >= 650)
            {
                enemy3.Top = -130;
                enemy3.Left = GenerateRandomPosition(430, 785, enemy1, enemy2, enemy4, coin);
            }

            if (enemy4.Top >= 650)
            {
                enemy4.Top = -400;
                enemy4.Left = GenerateRandomPosition(430, 785, enemy1, enemy2, enemy3, coin);
            }

            // Function to generate a random position for an enemy or coin that is not occupied by other enemies or coin
            int GenerateRandomPosition(int minX, int maxX, params PictureBox[] objects)
            {
                int position;
                do
                {
                    position = rand.Next(minX, maxX);
                } while (IsPositionOccupied(position, objects));

                return position;
            }

            // Function to check if a position is occupied by other enemies or coin
            bool IsPositionOccupied(int position, PictureBox[] objects)
            {
                foreach (var obj in objects)
                {
                    if (Math.Abs(obj.Left - position) < 50) // Adjust the threshold as needed
                    {
                        return true;
                    }
                }
                return false;
            }






            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds) || player.Bounds.IntersectsWith(enemy3.Bounds) || player.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
                lose = true;
            }

            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                labelCoins.Text = "Coins: " + countCoins.ToString();
                coin.Top = -50;

                coin.Left = rand.Next(25, 785);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return;

            int speed = 17;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 14)
            {
                player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 825)
            {
                player.Left += speed;
            }

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void labelLose_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void enemy3_Click(object sender, EventArgs e)
        {

        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            enemy3.Top = -730;
            enemy4.Top = -200;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer1.Enabled = true;
            lose = false;
            countCoins = 0;
            labelCoins.Text = "Coins: 0";
        }
    }
}
