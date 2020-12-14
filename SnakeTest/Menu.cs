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

        // Settings Menu
        private void CloseButtonClick(object sender, EventArgs e)
        {
            Settings.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Settings

        // Game Size
        private void GameSizeChange(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "S":
                    GameSettings.GameSize = 1;
                    GameSettings.CellSize = 40;
                    break;
                case "M":
                    GameSettings.GameSize = 2;
                    GameSettings.CellSize = 30;
                    break;
                case "L":
                    GameSettings.GameSize = 3;
                    GameSettings.CellSize = 25;
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

        }
    }
    
}
