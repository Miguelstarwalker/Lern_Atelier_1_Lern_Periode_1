using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Jumpy
{
    public partial class Form1 : Form
    {
        SoundPlayer Green = new SoundPlayer(Properties.Resources.Green_Greens___Kirby_s_dream_land);
        int pipeSpeed = 5;
        int gravity = 6;
        int score = 0;
        bool gameOver = false;
        bool scoredCurrentPipe = false;
        bool spaceHeld = false;
        int hopFrames = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            Green.PlayLooping();
        }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver && e.KeyCode == Keys.R)
            {
                restartGame();
                return;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (!spaceHeld)
                {
                    hopFrames = 6;
                }

                spaceHeld = true;
            }
        }
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            if (e.KeyCode == Keys.Space)
            {
                spaceHeld = false;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            gameOver = true;
            gameOverText.Visible = true;
            gameOverText.BringToFront();
            scoreText.Text = "Score: " + score;
        }
        private void restartGame()
        {
            gameOver = false;
            score = 0;
            pipeSpeed = 5;
            gravity = 6;
            scoredCurrentPipe = false;
            spaceHeld = false;
            hopFrames = 0;

            Kirby.Location = new Point(80, 200);
            resetPipePositions();
            scoreText.Text = "Score: 0";
            gameOverText.Visible = false;

            gameTimer.Start();
        }
        private void resetPipePositions()
        {
            int pipeLeft = ClientSize.Width + 120;
            int pipeWidth = random.Next(65, 91);
            int topMargin = 50;
            int bottomMargin = 40;
            int maxGapHeight = Math.Min(140, ground.Top - topMargin - bottomMargin);
            int gapHeight = random.Next(100, Math.Max(121, maxGapHeight + 1));
            int maxGapTop = Math.Max(topMargin, ground.Top - gapHeight - bottomMargin);
            int gapTop = random.Next(topMargin, maxGapTop + 1);

            pipeTop.Left = pipeLeft;
            pipeBottom.Left = pipeLeft;
            pipeTop.Width = pipeWidth;
            pipeBottom.Width = pipeWidth;

            pipeTop.Height = gapTop + 220;
            pipeTop.Top = -220;
            pipeBottom.Top = gapTop + gapHeight;
            pipeBottom.Height = ground.Top - pipeBottom.Top + 80;
            scoredCurrentPipe = false;
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (hopFrames > 0)
            {
                gravity = -8;
                hopFrames--;
            }
            else if (spaceHeld)
            {
                gravity = -6;
            }
            else
            {
                gravity = 6;
            }

            Kirby.Top += gravity;
            pipeBottom.Left -= pipeSpeed;

            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -pipeBottom.Width)
            {
                resetPipePositions();
            }
            if (!scoredCurrentPipe && pipeBottom.Right < Kirby.Left)
            {
                score++;
                scoredCurrentPipe = true;
            }


            if (Kirby.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                Kirby.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Kirby.Bounds.IntersectsWith(ground.Bounds) || Kirby.Top < -25
                )
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 8;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
