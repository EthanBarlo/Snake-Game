using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeTest
{
    public partial class Form1 : Form
    {
        string snakeDirectionImage; // make corners and stuff!
        SnakeGame snakeGame;

        public Form1()
        {
            InitializeComponent();
            snakeGame = new SnakeGame(this, GamePanel, SnakeHeadLabel);
            
        }

        // Sets the movement direction
        private void KeyHasBeenPressed(object sender, KeyEventArgs e)
        {
            snakeGame.ChangeDirection(e);
            
            if (MovementTimer.Enabled == false)
                MovementTimer.Start();
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
            MovementTimer.Start();
        }

        private void Reset()
        {
            // Resetting score and snakeHead location
            lblScore.Text = "0".PadLeft(7, '0');
            SnakeHeadLabel.Top = 240;
            SnakeHeadLabel.Left = 260;
            snakeGame.Reset();
        }

        // Fix for focus bug
        private void btnReset_Enter(object sender, EventArgs e)
        {
            SnakeHeadLabel.Focus();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            snakeGame.MoveSnake();
        }
    }
}
