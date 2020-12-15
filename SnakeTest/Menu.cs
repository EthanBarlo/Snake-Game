using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace SnakeTest
{
    public partial class Menu : Form
    {
        // Attributes
        GameForm game;
        Dictionary<string, string> SettingsDict =
                    new Dictionary<string, string>();

        public Menu()
        {
            InitializeComponent();

            btnPlay.Parent = MenuBackground;
            btnSettings.Parent = MenuBackground;
            btnQuit.Parent = MenuBackground;

            btnSizeLarge.Parent = SettingsBackground;
            btnSizeMedium.Parent = SettingsBackground;
            btnSizeSmall.Parent = SettingsBackground;
            btnTeleportTrue.Parent = SettingsBackground;
            btnTeleportFalse.Parent = SettingsBackground;
            btnSaveSettings.Parent = SettingsBackground;
            UpdateButtons();
        }

        // Main Menu

        private void SettingsClick(object sender, EventArgs e)
        {
            Settings.Visible = true;
        }

        private void PlayClicked(object sender, EventArgs e)
        {
            game = new GameForm();
            game.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Settings Menu

        // Game Size
        private void GameSizeChange(object sender, EventArgs e)
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



        // Update Buttons
        private void UpdateButtons()
        {
            btnSizeSmall.Enabled = GameSettings.GameSize != 1;
            btnSizeMedium.Enabled = GameSettings.GameSize != 2;
            btnSizeLarge.Enabled = GameSettings.GameSize != 3;

            btnTeleportTrue.Enabled = !GameSettings.Teleport;
            btnTeleportFalse.Enabled = GameSettings.Teleport;

        }

        private void btnTeleportClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Name == "btnTeleportTrue")
            {
                GameSettings.Teleport = true;
            }
            else
            {
                GameSettings.Teleport = false;
            }
            UpdateButtons();
        }

        private void SaveSettingsClick(object sender, EventArgs e)
        {
            Settings.Visible = false;
            GameSettings.SaveSettings();
        }
    }
    
}
