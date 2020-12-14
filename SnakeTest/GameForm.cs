using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeTest
{
    public partial class GameForm : Form
    {
        // Attributes
        SnakeGame snakeGame;
        bool pause = false;

        // Constructor
        public GameForm()
        {
            InitializeComponent();
            // Setting SnakeHead Up
            SnakeHeadBox.Width = GameSettings.CellSize;
            SnakeHeadBox.Height = GameSettings.CellSize;
            SnakeHeadBox.Left = (SnakeHeadBox.Location.X / GameSettings.CellSize) * GameSettings.CellSize;
            SnakeHeadBox.Top = (SnakeHeadBox.Location.Y / GameSettings.CellSize) * GameSettings.CellSize;

            snakeGame = new SnakeGame(GamePanel, SnakeHeadBox);
            SetLabelParents();

        }

        // Operations
        private void KeyHasBeenPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pause = !pause;
                if (pause) MovementTimer.Stop();
                else MovementTimer.Start();
            }

            else
                snakeGame.ChangeDirection(e);

            if (MovementTimer.Enabled == false)
            {
                MovementTimer.Start();
                btnReset.Enabled = true;
                SnakeHeadBox.Focus();
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
            // Center Location
            int center = ((GamePanel.Height / GameSettings.CellSize) / 2) * GameSettings.CellSize;

            // Resetting score and snakeHead location
            lblScore.Text = "0".PadLeft(7, '0');
            SnakeHeadBox.Top = center;
            SnakeHeadBox.Left = center;
            snakeGame.Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Try stop flashing (NOT WORKING)
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            // Setting Game Size
            switch (GameSettings.GameSize)
            {
                case 1:
                    GamePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BackgroundSmall));
                    break;
                case 2:
                    GamePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BackgroundMedium));
                    break;
                case 3:
                    GamePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.BackgroundLarge));
                    break;
            }

            


            // Leaderboard stuff
            //Leaderboard.LoadFile();
            //foreach (var item in Leaderboard.GetLeaderBoard())
            //{
            //    lbLeaderboard.Items.Add(item);
            //}
        }

        private void SetLabelParents()
        {
            // Score
            lblScoreText.Parent = GameBackground;
            lblScore.Parent = GameBackground;

            // Leaderboard
            lblLeaderboard.Parent = GameBackground;
            lblPlace1.Parent = GameBackground;
            lblPlace2.Parent = GameBackground;
            lblPlace3.Parent = GameBackground;
            lblPlace4.Parent = GameBackground;
            lblPlace5.Parent = GameBackground;
            lblPlace6.Parent = GameBackground;
            lblPlace7.Parent = GameBackground;
            lblPlace8.Parent = GameBackground;
            lblPlace9.Parent = GameBackground;
            lblPlace10.Parent = GameBackground;
            lblYouBottom.Parent = GameBackground;
        }
    }
}
