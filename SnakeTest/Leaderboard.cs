using System.Collections.Generic;
using System.IO;
using System.Linq;


static class Leaderboard
{
    // Attributes
    private static string fileName = "leaderBoard.txt";
    public static List<List<string>> leaderBoard;

    //  Initializer
    static Leaderboard()
    {
        LoadFile();
    }

    //-------------------------------------------------------------------------------------------
    // Public Operations
    // Leaderboard Operations
    public static void addNewScore(string score, string name, int gameSize, bool teleport)
    {
        if (name.Length > 6)
            name = name.Substring(0, 6);
        leaderBoard.Add(new List<string> { score, name.ToLower(), $"{gameSize}", $"{teleport}" });
        SaveToFile();
    }

    //-----------------------------------------------
    // Get top 10 Leaderboard with specific settings
    public static List<List<string>> GetShortLeaderBoard(int gameSize, bool teleport) 
    {
        // Get sorted list of scoreItems with the Specific Settings
        var SizeList = GetSpecificSettings(gameSize, teleport);
        
        // Generate Output
        var OutputLeaderBoard = new List<List<string>>();
        int counter = 0; 
        foreach (var scoreItem in SizeList)
        {
            OutputLeaderBoard.Add(new List<string>{scoreItem[1] + new string(' ', 10 - scoreItem[0].Length), scoreItem[0]});
            counter++;
            if (counter == 10) break; // Only grabs top 10
        }
        return OutputLeaderBoard;
    }

    //-----------------------------------------------
    // Get all scores with specific settings in order
    private static List<List<string>> GetSpecificSettings(int size, bool teleport)
    {
        //    0   :   1  :     2    :    3
        //  Score : Name : GameSize : Teleport
        var outputList = leaderBoard.FindAll(s => int.Parse(s[2]) == size)
                                    .FindAll(t => bool.Parse(t[3]) == teleport)
                                    .OrderByDescending(o => int.Parse(o[0]))
                                    .ToList();
        return outputList;
    }


    //-------------------------------------------------------------------------------------------
    // Private Operations
    // Load/Save to file
    private static void LoadFile()
    {
        if (File.Exists(fileName))
        {
            leaderBoard = new List<List<string>>();
            foreach (var line in File.ReadAllLines(fileName))
            {
                leaderBoard.Add(line.Split(':').ToList());
            }
        }
        else
            leaderBoard = new List<List<string>>();
    }

    private static void SaveToFile()
    {
        string SaveOutput = "";
        foreach (var scoreItem in leaderBoard)
        {
            //              Score:Name:GameSize:Teleport
            SaveOutput += $"{scoreItem[0]}:{scoreItem[1]}:{scoreItem[2]}:{scoreItem[3]}";
            SaveOutput += "\n";
        }
        File.WriteAllText(fileName, SaveOutput);
    }
}
