using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SnakeTest
{
    public partial class Menu : Form
    {
        // Attributes
        GameForm game;
        string lbSortSize = "";
        string lbSortTeleport = "";
        List<List<string>> leaderBoard;

        // Initializer
        public Menu()
        {
            InitializeComponent();
            SetParents();
            leaderBoard = Leaderboard.GetLeaderBoard();
            UpdateLeaderboard();
            UpdateButtons();
        }

        //-------------------------------------------------------------------------------------------
        // Main menu Operations
        private void PlayClicked(object sender, EventArgs e)
        {
            game = new GameForm();
            game.ShowDialog();
        }

        private void SettingsClick(object sender, EventArgs e)
        {
            SettingsPannel.Visible = true;
        }

        private void LeaderboardOpen(object sender, EventArgs e)
        {
            LeaderBoardPanel.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-------------------------------------------------------------------------------------------
        // Settings menu Operations
        private void GameSizeBtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnSizeSmall":
                    GameSettings.ChangeGameSize(1);
                    break;
                case "btnSizeMedium":
                    GameSettings.ChangeGameSize(2);
                    break;
                case "btnSizeLarge":
                    GameSettings.ChangeGameSize(3);
                    break;
            }

            UpdateButtons();
        }

        private void btnTeleportClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name == "btnTeleportTrue")
                GameSettings.Teleport = true;
            else
                GameSettings.Teleport = false;

            UpdateButtons();
        }

        private void SaveSettingsClick(object sender, EventArgs e)
        {
            SettingsPannel.Visible = false;
            GameSettings.SaveSettings();
        }

        private void UpdateButtons()
        {
            // Settings Buttons
            btnSizeSmall.Enabled = GameSettings.GameSize != 1;
            btnSizeMedium.Enabled = GameSettings.GameSize != 2;
            btnSizeLarge.Enabled = GameSettings.GameSize != 3;
            btnTeleportTrue.Enabled = !GameSettings.Teleport;
            btnTeleportFalse.Enabled = GameSettings.Teleport;
        }

        //-------------------------------------------------------------------------------------------
        // Leaderboard Operations
        private void LBoardSize(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "lbtnSmall":
                    lbSortSize += "1";
                    break;
                case "lbtnMedium":
                    lbSortSize += "2";
                    break;
                case "lbtnLarge":
                    lbSortSize += "3";
                    break;
            }
            btn.Enabled = false;

            UpdateLeaderboard();
        }

        private void LBoardTeleport(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == "lbtnTrue")
                lbSortTeleport += "true";
            else
                lbSortTeleport += "false";

            if (lbSortTeleport == "truefalse" || lbSortTeleport == "falsetrue")
                lbSortTeleport = "";
            btn.Enabled = false;

            UpdateLeaderboard();
        }

        private void LBoardClear(object sender, EventArgs e)
        {
            lbSortSize = "";
            lbSortTeleport = "";

            // Re-enabling buttons
            lbtnFalse.Enabled = true;
            lbtnTrue.Enabled = true;
            lbtnLarge.Enabled = true;
            lbtnMedium.Enabled = true;
            lbtnSmall.Enabled = true;

            UpdateLeaderboard();
        }

        private void UpdateLeaderboard()
        {
            var OutputList = new List<List<string>>();
            //    0   :   1  :     2    :    3
            //  Score : Name : GameSize : Teleport

            // Sorting Game Size
            if (lbSortSize.Length >= 1)
            {
                foreach (var character in lbSortSize)
                {
                    OutputList.AddRange(leaderBoard.FindAll(f => f[2] == $"{character}"));
                }
            }
            if (lbSortSize == "")
            {
                OutputList.AddRange(leaderBoard);
            }

            // Sorting Teleport
            if (lbSortTeleport != "")
            {
                OutputList = OutputList.FindAll(f => f[3] == lbSortTeleport);
            }

            lbLeaderboard.Items.Clear();
            foreach(var scoreItem in OutputList.OrderByDescending(o => int.Parse(o[0])))
            {
                lbLeaderboard.Items.Add($"{scoreItem[0]}   {scoreItem[1].PadRight(12 - scoreItem[1].Length)}\t{scoreItem[2]}      {scoreItem[3]}");
            }
        }

        private void LeaderboardClose(object sender, EventArgs e)
        {
            LeaderBoardPanel.Visible = false;
        }

        //-------------------------------------------------------------------------------------------
        // Misc

        private void SetParents()
        {
            // Main Menu
            btnPlay.Parent = MenuBackground;
            btnSettings.Parent = MenuBackground;
            btnLeaderboard.Parent = MenuBackground;
            btnQuit.Parent = MenuBackground;

            // Settings Menu
            btnSizeLarge.Parent = SettingsBackground;
            btnSizeMedium.Parent = SettingsBackground;
            btnSizeSmall.Parent = SettingsBackground;
            btnTeleportTrue.Parent = SettingsBackground;
            btnTeleportFalse.Parent = SettingsBackground;
            btnSaveSettings.Parent = SettingsBackground;

            // Leaderboard Menu
            lbLeaderboard.Parent = LeaderboardBackground;
            lbtnAll.Parent = LeaderboardBackground;
            lbtnClose.Parent = LeaderboardBackground;
            lbtnFalse.Parent = LeaderboardBackground;
            lbtnLarge.Parent = LeaderboardBackground;
            lbtnMedium.Parent = LeaderboardBackground;
            lbtnSmall.Parent = LeaderboardBackground;
            lbtnTrue.Parent = LeaderboardBackground;
        }
    }
}
