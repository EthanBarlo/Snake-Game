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
        static public int CellSize = 30;

        // Constructor
        static GameSettings()
        {
            LoadSettings();
        }


        // Operations
        static public void ChangeGameSize(int newSize)
        {
            switch (newSize)
            {
                case 1:
                    GameSettings.GameSize = 1;
                    GameSettings.CellSize = 40;
                    break;
                case 2:
                    GameSettings.GameSize = 2;
                    GameSettings.CellSize = 30;
                    break;
                case 3:
                    GameSettings.GameSize = 3;
                    GameSettings.CellSize = 25;
                    break;
            }
        }

        static public void LoadSettings()
        {
            if (File.Exists(fileName))
            {
                string[] settings = File.ReadAllLines(fileName);
                ChangeGameSize(Convert.ToInt32(settings[0]));
                Teleport = Convert.ToBoolean(settings[1]);
            }
        }

        static public void SaveSettings()
        {
            string[] settings = { $"{GameSize}", $"{Teleport}"};
            File.WriteAllLines(fileName, settings);
        }
    }
}
