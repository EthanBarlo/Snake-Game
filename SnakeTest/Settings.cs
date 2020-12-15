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
        static public bool Teleport = true;
        static public int snakeSpeed = 2;
        static public int CellSize = 30;

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
                Teleport = Convert.ToBoolean(settings[1]);
                snakeSpeed = Convert.ToInt32(settings[2]);
            }
        }

        static public void SaveSettings()
        {
            string[] settings = { $"{GameSize}", $"{Teleport}", $"{snakeSpeed}" };
            File.WriteAllLines(fileName, settings);
        }
    }
}
