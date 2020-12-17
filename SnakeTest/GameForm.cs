using System;
using System.Collections.Generic;
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
        int scoreMultiplyer;

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

            // Setting Game Size
            switch (GameSettings.GameSize)
            {
                case "S":
                    GamePanel.BackgroundImage = Properties.Resources.BackgroundSmall;
                    break;
                case "M":
                    GamePanel.BackgroundImage = Properties.Resources.BackgroundMedium;
                    break;
                case "L":
                    GamePanel.BackgroundImage = Properties.Resources.BackgroundLarge;
                    break;
            }

            // Setting the correct SnakeHead Size
            SnakeHeadBox.Width = GameSettings.CellSize;
            SnakeHeadBox.Height = GameSettings.CellSize;
            SnakeHeadBox.Left = (SnakeHeadBox.Location.X / GameSettings.CellSize) * GameSettings.CellSize;
            SnakeHeadBox.Top = (SnakeHeadBox.Location.Y / GameSettings.CellSize) * GameSettings.CellSize;

            // New snakeGame, and setting up labels
            snakeGame = new SnakeGame(GamePanel, SnakeHeadBox, this);
            SetParents();
            LoadLeaderboard();
        }

        //-------------------------------------------------------------------------------------------
        // Game Operations
        private void KeyHasBeenPressed(object sender, KeyEventArgs e)
        {
            // Pause
            if (e.KeyCode == Keys.Escape)
                PauseGame();
            else
                snakeGame.ChangeDirection(e);

            // Start timer if not paused
            if (pause == false && MovementTimer.Enabled == false)
            {
                MovementTimer.Start();
                ResetMultiplyer();
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            snakeGame.MoveSnake();
        }

        // Every half second / 5 spaces on the grid
        private void ScoreMultiplierTick(object sender, EventArgs e)
        {
            scoreMultiplyer--;
            if (scoreMultiplyer == 4)
                ScoreMultiplyerTimer.Stop();
            lblMultiplier.Text = Convert.ToString(scoreMultiplyer);
        }

        public void IncreaseScore()
        {
            score += 1 * scoreMultiplyer;
            ResetMultiplyer();
            // Set Score Label
            // Max score check, might as well
            if (Convert.ToInt32(lblScore.Text) == 999999) 
            { 
                MessageBox.Show("Max Score reached"); 
                MovementTimer.Stop(); 
            }
            lblScore.Text = $"{score}".PadLeft(6, '0');

            // Update Score in leaderboard
            leaderboard[userScoreIndex][1] = lblScore.Text;
            UpdateLeaderboard();
        }

        private void ResetMultiplyer()
        {
            scoreMultiplyer = 10;
            lblMultiplier.Text = Convert.ToString(scoreMultiplyer);
            ScoreMultiplyerTimer.Stop();
            ScoreMultiplyerTimer.Start();
        }

        private void PauseGame()
        {
            pause = !pause;
            if (pause)
                MovementTimer.Stop();
            else
                MovementTimer.Start();
        }

        private void ResetScore()
        {
            // Resetting score
            lblScore.Text = "0".PadLeft(6, '0');
            score = 0;
        }

        public void GameOver()
        {
            PauseGame();
            ScoreMultiplyerTimer.Stop();
            GameOverPanel.Visible = true;
        }

        //-------------------------------------------------------------------------------------------
        // LeaderBoard
        private void LoadLeaderboard()
        {
            // Grabs the leaderboard of scores with the same settings
            leaderboard = Leaderboard.GetShortLeaderBoard(GameSettings.GameSize, GameSettings.Teleport);

            // Adds current player to leaderboard
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
            // Only updates and makes visible labels that are used.
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

            // If leaderboard is full, currentPlayer is placed at the bottom
            if (userScoreIndex == 10)
            {
                var scoreItem = leaderboard[userScoreIndex];
                lblYouBottom.Text = scoreItem[0] + scoreItem[1];
                lblYouBottom.Visible = true;
            }
            else
                lblYouBottom.Visible = false;

            // Moving the leaderboard Snake
            leaderBoardSnake.Top = 390 + (35 * userScoreIndex);
        }

        private void SetLeaderboardValues(Label label, Label numLabel, List<string> scoreItem)
        {
            label.Text = scoreItem[0] + scoreItem[1];
            label.Visible = true;
            numLabel.Visible = true;
        }

        private void AddScoreClick(object sender, EventArgs e)
        {
            // Updating global leaderboard
            Leaderboard.addNewScore(lblScore.Text, tbName.Text, GameSettings.GameSize, GameSettings.Teleport);

            // Reset GameForm settings
            ResetScore();
            GameOverPanel.Visible = false;
            pause = false;

            // Updating local leaderboard, If the player wants to play multiple times
            tbName.Text = tbName.Text.Substring(0, 6);
            leaderboard[userScoreIndex][0] = tbName.Text + new string(' ', 10 - tbName.Text.Length);
            userScoreIndex = leaderboard.Count;
            leaderboard.Add(new List<string> { "You       ", lblScore.Text });

            UpdateLeaderboard();
        }

        private void GameOverClose(object sender, EventArgs e)
        {
            // Reset GameForm settings
            ResetScore();
            GameOverPanel.Visible = false;
            pause = false;

            // Updating local leaderboard, for it the player wants to play multiple times
            leaderboard.RemoveAt(userScoreIndex);
            userScoreIndex = leaderboard.Count;
            leaderboard.Add(new List<string> { "You       ", lblScore.Text });

            UpdateLeaderboard();
        }

        //-------------------------------------------------------------------------------------------
        // Misc
        private void SetParents()
        {
            // Score
            lblScore.Parent = GameBackground;
            lblScoreText.Parent = GameBackground;

            // Multiplier
            lblMultiplier.Parent = GameBackground;
            lblMultiplierText.Parent = GameBackground;
            MultiplierBox.Parent = GameBackground;

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

            // Leaderboard Snake
            leaderBoardSnake.Parent = GameBackground;

            // Game Over
            lblGameOver.Parent = GameOverBackground;
            lblEnterName.Parent = GameOverBackground;
        }
    }
}
