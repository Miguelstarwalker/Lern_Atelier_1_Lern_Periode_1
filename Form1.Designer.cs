﻿namespace Jumpy
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            Kirby = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameOverText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Kirby).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(620, -220);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(75, 380);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(620, 320);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(75, 280);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 1;
            pipeBottom.TabStop = false;
            // 
            // Kirby
            // 
            Kirby.Image = Properties.Resources.bird;
            Kirby.Location = new Point(80, 240);
            Kirby.Name = "Kirby";
            Kirby.Size = new Size(55, 45);
            Kirby.SizeMode = PictureBoxSizeMode.StretchImage;
            Kirby.TabIndex = 2;
            Kirby.TabStop = false;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-10, 550);
            ground.Name = "ground";
            ground.Size = new Size(520, 95);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Moccasin;
            scoreText.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(160, 580);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(122, 37);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            // 
            // gameOverText
            // 
            gameOverText.BackColor = Color.FromArgb(220, 255, 248, 220);
            gameOverText.Font = new Font("Arial Narrow", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameOverText.Location = new Point(75, 230);
            gameOverText.Name = "gameOverText";
            gameOverText.Size = new Size(350, 130);
            gameOverText.TabIndex = 5;
            gameOverText.Text = "Game Over!\r\nPress R to retry";
            gameOverText.TextAlign = ContentAlignment.MiddleCenter;
            gameOverText.Visible = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 640);
            Controls.Add(gameOverText);
            Controls.Add(scoreText);
            Controls.Add(Kirby);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kirby Jump";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)Kirby).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox Kirby;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
