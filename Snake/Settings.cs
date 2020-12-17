using System;
using System.IO;


namespace Snake
{
    static class GameSettings
    {
        // Attributes
        static private string fileName = "gameSettings.txt";
        static public string GameSize = "M";
        static public bool Teleport = true;
        static public int CellSize = 30;

        // Initializer
        static GameSettings()
        {
            LoadSettings();
        }

        //-------------------------------------------------------------------------------------------
        // Public Operations
        static public void ChangeGameSize(string newSize)
        {
            switch (newSize)
            {
                case "S":
                    GameSettings.GameSize = "S";
                    GameSettings.CellSize = 40;
                    break;
                case "M":
                    GameSettings.GameSize = "M";
                    GameSettings.CellSize = 30;
                    break;
                case "L":
                    GameSettings.GameSize = "L";
                    GameSettings.CellSize = 25;
                    break;
            }
        }

        static public void SaveSettings()
        {
            string[] settings = { $"{GameSize}", $"{Teleport}"};
            File.WriteAllLines(fileName, settings);
        }

        //-------------------------------------------------------------------------------------------
        // Private Operations
        // Loading the settings on program start.
        static public void LoadSettings()
        {
            if (File.Exists(fileName))
            {
                string[] settings = File.ReadAllLines(fileName);
                ChangeGameSize(settings[0]);
                Teleport = Convert.ToBoolean(settings[1]);
            }
        }
    }
}
