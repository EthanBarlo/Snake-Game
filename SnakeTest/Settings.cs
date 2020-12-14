using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SnakeTest
{
    static class GameSettings
    {
        // Attributes
        static public string fileName = "gameSettings.txt";
        static public int GameSize = 2;
        static public bool wallTeleport = true;
        static public int snakeSpeed = 2;
        static public int CellSize = 25;

        // Constructor
        static GameSettings()
        {
            LoadSettings();
        }


        // Operations
        static public void LoadSettings()
        {
            if (File.Exists(fileName))
            {
                string[] settings = File.ReadAllLines(fileName);
                GameSize = Convert.ToInt32(settings[0]);
                wallTeleport = Convert.ToBoolean(settings[1]);
                snakeSpeed = Convert.ToInt32(settings[2]);
            }
        }

        static public void SaveSettings()
        {
            string[] settings = { $"{GameSize}", $"{wallTeleport}", $"{snakeSpeed}" };
            File.WriteAllLines(fileName, settings);
        }
    }
}
