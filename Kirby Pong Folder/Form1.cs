using Microsoft.VisualBasic.Devices;
using System.Media;
using System.Numerics;

namespace Pong
{
    public partial class Form1 : Form
    {
        SoundPlayer Kirby = new SoundPlayer(Properties.Resources.Green_Greens___Kirby_s_dream_land);
        int ballXspeed = 4;
        int ballYspeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        int Keeby_speed_change = 50;
        int KirbyScore = 0;
        int KeebyScore = 0;
        int KirbySpeed = 8;
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 9, 8, 11, 12 };


        public Form1()
        {
            InitializeComponent();
            Kirby.PlayLooping();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            ball.Top -= ballYspeed;

            ball.Left -= ballXspeed;
            this.Text = "Kirby Score: " + KirbyScore + " - Keeby Score: " + KeebyScore;
            if (ball.Top < 0 || ball.Bottom > this.ClientSize.Height)
            {
                ballYspeed = -ballYspeed;
            }
            if (ball.Left < -2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                KeebyScore++;
            }
            if (ball.Right > this.ClientSize.Width + 2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                KirbyScore++;
            }
            if (computer.Top <= 1)
            {
                computer.Top = 0;
            }
            else if (computer.Bottom >= this.ClientSize.Height)
            {
                computer.Top = this.ClientSize.Height - computer.Height;
            }
            if (ball.Top < computer.Top + (computer.Height / 2) && ball.Left > 300)
            {
                computer.Top -= speed;
            }
            if (ball.Top > computer.Top + (computer.Height / 2) && ball.Left > 300)
            {
                computer.Top += speed;
            }
            Keeby_speed_change -= 1;
            if (Keeby_speed_change < 0)
            {
                speed = i[rand.Next(i.Length)];
                Keeby_speed_change = 50;
            }
            if (goDown && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += KirbySpeed;
            }
            if (goUp && player.Top > 0)
            {
                player.Top -= KirbySpeed;
            }
            CheckCollision(ball, player, player.Right + 5);
            CheckCollision(ball, computer, computer.Left - 35);
            if (KeebyScore > 5)
            {
                GameOver("Sorry you lost the game :[");
            }
            else if (KirbyScore > 5)
            {
                GameOver("You Won this game :]");
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;
                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];
                if (ballXspeed < 0)
                {
                    ballXspeed = x;
                }
                else
                {
                    ballXspeed = -x;
                }
                if (ballYspeed < 0)
                {
                    ballYspeed = -y;
                }
                else
                {
                    ballYspeed = y;
                }
            }
        }

        private void GameOver(string message)
        {
            GameTimer.Stop();
            MessageBox.Show(message, "Kirby Says: ");
            KeebyScore = 0;
            KirbyScore = 0;
            ballXspeed = ballYspeed = 4;
            Keeby_speed_change = 50;
            GameTimer.Start();

        }



    }
}
