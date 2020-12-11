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
            GameSettings.LoadSettings();
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
    }
    static class GameSettings
    {
        // Attributes
        static string fileName = "gameSettings.txt";
        static int gameSize = 2;
        static bool wallTeleport = true;
        static int snakeSpeed = 2;

        // Operations
        static public void LoadSettings()
        {
            if (File.Exists(fileName))
            {
                string[] settings =  File.ReadAllLines(fileName);
                gameSize = Convert.ToInt32(settings[0]);
                wallTeleport = Convert.ToBoolean(settings[1]);
                snakeSpeed = Convert.ToInt32(settings[2]);
            }
        }

        static public void SaveSettings()
        {
            string[] settings = {$"{gameSize}", $"{wallTeleport}", $"{snakeSpeed}"};
            File.WriteAllLines(fileName, settings);
        }
    }
}
