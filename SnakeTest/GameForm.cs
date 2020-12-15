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
        List<List<string>> leaderboard;
        int userScoreIndex;

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
            UpdateLeaderboard();
        }
        private void SnakeHit()
        {
            gameEnd();
        }

        public void IncreaseScore()
        {
            if (Convert.ToInt32(lblScore.Text) == 999999) { MessageBox.Show("Max Score reached"); MovementTimer.Stop(); }
            lblScore.Text = Convert.ToString(Convert.ToInt32(lblScore.Text) + 1).PadLeft(6, '0');

            leaderboard[userScoreIndex][1] = lblScore.Text;
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
            lblScore.Text = "0".PadLeft(6, '0');
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
            int leaderboardLength = leaderboard.Count;
            leaderboard.Add(new List<string> { "You       ", lblScore.Text });
            userScoreIndex = leaderboardLength;
            // leaderboard is a List<List<string>>, First item is Score, Second Is Name

            if (leaderboardLength >= 1 && leaderboard[0] != null)
                SetLeaderboardValues(lblPlace1, lbl1, leaderboard[0]);
            if (leaderboardLength >= 2 && leaderboard[1] != null)
                SetLeaderboardValues(lblPlace2, lbl2, leaderboard[1]);
            if (leaderboardLength >= 3 && leaderboard[2] != null) 
                SetLeaderboardValues(lblPlace3, lbl3, leaderboard[2]);
            if (leaderboardLength >= 4 && leaderboard[3] != null) 
                SetLeaderboardValues(lblPlace4, lbl4, leaderboard[3]);
            if (leaderboardLength >= 5 && leaderboard[4] != null)
                SetLeaderboardValues(lblPlace5, lbl5, leaderboard[4]);
            if (leaderboardLength >= 6 && leaderboard[5] != null) 
                SetLeaderboardValues(lblPlace6, lbl6, leaderboard[5]);
            if (leaderboardLength >= 7 && leaderboard[6] != null)
                SetLeaderboardValues(lblPlace7, lbl7, leaderboard[6]);
            if (leaderboardLength >= 8 && leaderboard[7] != null)
                SetLeaderboardValues(lblPlace8, lbl8, leaderboard[7]);
            if (leaderboardLength >= 9 && leaderboard[8] != null)
                SetLeaderboardValues(lblPlace9, lbl9, leaderboard[8]);
            if (leaderboardLength >= 10 && leaderboard[9] != null)
                SetLeaderboardValues(lblPlace10, lbl10, leaderboard[9]);
        }

        private void SetLeaderboardValues(Label label, Label numLabel, List<string> leaderboard)
        {
            label.Text = leaderboard[0] + leaderboard[1];
            label.Visible = true;
            numLabel.Visible = true;
        }

        private void UpdateLeaderboard()
        {
            int currentScore = int.Parse(lblScore.Text);
            for (int i = 0; i < 10; i++)
            {
                if (int.Parse(leaderboard[i][1]) < currentScore)
                {
                    if (i == userScoreIndex) break;
                    var temp = leaderboard[i];
                    leaderboard[i] = new List<string> { "You       ", lblScore.Text };
                    leaderboard[userScoreIndex] = temp;
                    userScoreIndex = i;
                }
            }
        }

        private void SetLabelParents()
        {
            // Score
            lblScore.Parent = GameBackground;
            lblScoreText.Parent = GameBackground;

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
            // Leaderboard Numbers
            lbl1.Parent = GameBackground;
            lbl2.Parent = GameBackground;
            lbl3.Parent = GameBackground;
            lbl4.Parent = GameBackground;
            lbl5.Parent = GameBackground;
            lbl6.Parent = GameBackground;
            lbl7.Parent = GameBackground;
            lbl8.Parent = GameBackground;
            lbl9.Parent = GameBackground;
            lbl10.Parent = GameBackground;

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

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
