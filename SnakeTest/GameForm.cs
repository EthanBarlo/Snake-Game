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
        public bool pause = false;
        List<List<string>> leaderboard;
        int userScoreIndex;
        int score = 0;

        // Constructor
        public GameForm()
        {
            InitializeComponent();
            // Attempt to lessen the 'Flashing'
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            // Setting SnakeHead Up
            SnakeHeadBox.Width = GameSettings.CellSize;
            SnakeHeadBox.Height = GameSettings.CellSize;
            SnakeHeadBox.Left = (SnakeHeadBox.Location.X / GameSettings.CellSize) * GameSettings.CellSize;
            SnakeHeadBox.Top = (SnakeHeadBox.Location.Y / GameSettings.CellSize) * GameSettings.CellSize;

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

            snakeGame = new SnakeGame(GamePanel, SnakeHeadBox, this);
            SetLabelParents();
            LoadLeaderboard();
        }

        //-------------------------------------------------------------------------------------------
        // Game Operations
        private void KeyHasBeenPressed(object sender, KeyEventArgs e)
        {
            // Pause
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
                }
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            snakeGame.MoveSnake();
        }

        private void SnakeHit()
        {
            gameEnd();
        }

        public void IncreaseScore()
        {
            score += 1;
            // Set Score Label
            if (Convert.ToInt32(lblScore.Text) == 999999) { MessageBox.Show("Max Score reached"); MovementTimer.Stop(); }
            lblScore.Text = Convert.ToString($"{score}".PadLeft(6, '0'));

            // Update Score in leaderboard
            leaderboard[userScoreIndex][1] = lblScore.Text;
            UpdateLeaderboard();
        }

        public void gameEnd()
        {
            PauseGame();
            GameOverPanel.Visible = true;
        }

        private void Reset()
        {
            // Resetting score
            lblScore.Text = "0".PadLeft(6, '0');
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

        //-------------------------------------------------------------------------------------------
        // LeaderBoard

        private void LoadLeaderboard()
        {
            leaderboard = Leaderboard.GetShortLeaderBoard(GameSettings.GameSize);
            userScoreIndex = leaderboard.Count;
            leaderboard.Add(new List<string> { "You       ", lblScore.Text });
            UpdateLeaderboard();
        }

        private void UpdateLeaderboard()
        {
            // Moving current score up if higher than others
            for (int i = 0; i < 10; i++)
            {
                if (i == userScoreIndex) break;
                if (int.Parse(leaderboard[i][1]) < score)
                {
                    leaderboard.RemoveAt(userScoreIndex);
                    leaderboard.Insert(i, new List<string> { "You    ", lblScore.Text });
                    userScoreIndex = i;
                    break;
                }
            }

            // Updating the labels
            int leaderboardLength = leaderboard.Count;
            if (leaderboardLength >= 1)
                SetLeaderboardValues(lblPlace1, lbl1, leaderboard[0]);
            if (leaderboardLength >= 2)
                SetLeaderboardValues(lblPlace2, lbl2, leaderboard[1]);
            if (leaderboardLength >= 3)
                SetLeaderboardValues(lblPlace3, lbl3, leaderboard[2]);
            if (leaderboardLength >= 4)
                SetLeaderboardValues(lblPlace4, lbl4, leaderboard[3]);
            if (leaderboardLength >= 5)
                SetLeaderboardValues(lblPlace5, lbl5, leaderboard[4]);
            if (leaderboardLength >= 6)
                SetLeaderboardValues(lblPlace6, lbl6, leaderboard[5]);
            if (leaderboardLength >= 7)
                SetLeaderboardValues(lblPlace7, lbl7, leaderboard[6]);
            if (leaderboardLength >= 8)
                SetLeaderboardValues(lblPlace8, lbl8, leaderboard[7]);
            if (leaderboardLength >= 9)
                SetLeaderboardValues(lblPlace9, lbl9, leaderboard[8]);
            if (leaderboardLength >= 10)
                SetLeaderboardValues(lblPlace10, lbl10, leaderboard[9]);
            if (userScoreIndex == 10)
            {
                var scoreItem = leaderboard[userScoreIndex];
                lblYouBottom.Text = scoreItem[0] + scoreItem[1];
                lblYouBottom.Visible = true;
            }    

            // Moving the leaderboard Snake
            leaderBoardSnake.Top = 390 + (35 * userScoreIndex);
        }

        private void SetLeaderboardValues(Label label, Label numLabel, List<string> leaderboard)
        {
            label.Text = leaderboard[0] + leaderboard[1];
            label.Visible = true;
            numLabel.Visible = true;
        }

        private void AddScoreClick(object sender, EventArgs e)
        {
            Leaderboard.addNewScore(lblScore.Text, tbName.Text, GameSettings.GameSize);
            GameOverPanel.Visible = false;
            pause = false;
            Reset();
            UpdateLeaderboard();
        }

        private void GameOverClose(object sender, EventArgs e)
        {
            GameOverPanel.Visible = false;
            pause = false;
            Reset();
            pause = false;
        }

        //-------------------------------------------------------------------------------------------
        // Misc
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

            leaderBoardSnake.Parent = GameBackground;

            // Game Over
            lblGameOver.Parent = GameOverBackground;
            lblEnterName.Parent = GameOverBackground;
        }
    }
}
