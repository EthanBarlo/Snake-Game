using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeTest
{
    public partial class Form1 : Form
    {
        // Attributes
        SnakeGame snakeGame;

        // Constructor
        public Form1()
        {
            InitializeComponent();
            snakeGame = new SnakeGame(this, GamePanel, SnakeHeadLabel);
            
        }

        // Operations
        private void KeyHasBeenPressed(object sender, KeyEventArgs e)
        {
            snakeGame.ChangeDirection(e);
            
            if (MovementTimer.Enabled == false)
            {
                MovementTimer.Start();
                btnReset.Enabled = true;
                SnakeHeadLabel.Focus();
            }

        }

        private void TimerTick(object sender, EventArgs e)
        {
            snakeGame.MoveSnake();

            if (snakeGame.HasColission() == "apple")
            {
                AppleHit();
            }
            else if (snakeGame.HasColission() == "snakeBody")
            {
                SnakeHit();
            }
        }

        private void AppleHit()
        {
            IncreaseScore();
            snakeGame.AppleEaten();
        }
        private void SnakeHit()
        {
            gameEnd();
        }

        public void IncreaseScore()
        {
            if (Convert.ToInt32(lblScore.Text) == 9999999) { MessageBox.Show("Max Score reached"); MovementTimer.Stop(); }
            lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1).PadLeft(7, '0');
        }

        private void gameEnd()
        {
            btnReset.Enabled = true;
            MovementTimer.Stop();
            MessageBox.Show($"You Died!\nFinal Score: {Convert.ToInt32(lblScore.Text)}");
            Reset();
        }

        private void btnRestart_Click(object sender, EventArgs e)   //not in use
        {
            btnReset.Enabled = false;
            Reset();
            MovementTimer.Stop();
        }

        private void Reset()
        {
            // Resetting score and snakeHead location
            lblScore.Text = "0".PadLeft(7, '0');
            SnakeHeadLabel.Top = 240;
            SnakeHeadLabel.Left = 260;
            snakeGame.Reset();
        }
    }
}
