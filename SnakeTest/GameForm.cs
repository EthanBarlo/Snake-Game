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
        List<string> leaderboard;

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

            if (pause == false)
            {
                if (MovementTimer.Enabled == false)
                {
                    MovementTimer.Start();
                    btnReset.Enabled = true;
                    SnakeHeadBox.Focus();
                }
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
            GameOverPanel.Visible = true;
            PauseGame();
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

        private void PauseGame()
        {
            if (pause)
            {
                MovementTimer.Start();
            }
            else
            {
                MovementTimer.Stop();
            }
            pause = !pause;
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

            // Leaderboard Stuff
            leaderboard = Leaderboard.GetShortLeaderBoard(GameSettings.GameSize);
            int boardLength = leaderboard.Count;
            if (boardLength >= 1 && leaderboard[0] != null) lblPlace1.Text = leaderboard[0];
            if (boardLength >= 2 && leaderboard[1] != null) lblPlace2.Text = leaderboard[1];
            if (boardLength >= 3 && leaderboard[2] != null) lblPlace3.Text = leaderboard[2];
            if (boardLength >= 4 && leaderboard[3] != null) lblPlace4.Text = leaderboard[3];
            if (boardLength >= 5 && leaderboard[4] != null) lblPlace5.Text = leaderboard[4];
            if (boardLength >= 6 && leaderboard[5] != null) lblPlace6.Text = leaderboard[5];
            if (boardLength >= 7 && leaderboard[6] != null) lblPlace7.Text = leaderboard[6];
            if (boardLength >= 8 && leaderboard[7] != null) lblPlace8.Text = leaderboard[7];
            if (boardLength >= 9 && leaderboard[8] != null) lblPlace9.Text = leaderboard[8];
            if (boardLength >= 10 && leaderboard[9] != null) lblPlace10.Text = leaderboard[9];


        }


        private void SetLabelParents()
        {
            // Score
            ScorePanel.Parent = GameBackground;

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

            // Game Over
            lblGameOver.Parent = GameOverBackground;
            lblEnterName.Parent = GameOverBackground;
        }

        private void AddScoreClick(object sender, EventArgs e)
        {
            Leaderboard.addNewScore(lblScore.Text, tbName.Text, GameSettings.GameSize);

            Reset();
            GameOverPanel.Visible = false;
            pause = false;
        }
    }
}
