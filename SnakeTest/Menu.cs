using System;
using System.Windows.Forms;


namespace SnakeTest
{
    public partial class Menu : Form
    {
        // Attributes
        GameForm game;

        // Initializer
        public Menu()
        {
            InitializeComponent();
            SetParents();
            UpdateButtons();
        }

        //-------------------------------------------------------------------------------------------
        // Main menu Operations
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
            Settings.Visible = false;
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
        // Misc
        private void SetParents()
        {
            // Main Menu
            btnPlay.Parent = MenuBackground;
            btnSettings.Parent = MenuBackground;
            btnQuit.Parent = MenuBackground;

            // Settings Menu
            btnSizeLarge.Parent = SettingsBackground;
            btnSizeMedium.Parent = SettingsBackground;
            btnSizeSmall.Parent = SettingsBackground;
            btnTeleportTrue.Parent = SettingsBackground;
            btnTeleportFalse.Parent = SettingsBackground;
            btnSaveSettings.Parent = SettingsBackground;
        }
    }
}
