
using System.Collections.Generic;
using System.IO;
using System.Linq;


static class Leaderboard
{
    // Attributes
    private static string fileName = "leaderBoard.txt";
    public static List<List<string>> leaderBoard;
    
    
    static Leaderboard()
    {
        LoadFile();
    }


    // Edit Leaderboard
    public static void addNewScore(string score, string name, int gameSize, bool teleport)
    {
        if (name.Length > 6)
            name = name.Substring(0, 6);
        leaderBoard.Add(new List<string> { score, name.ToLower(), $"{gameSize}", $"{teleport}" });
        SaveToFile();
    }


    //Get leaderBoard
    public static List<List<string>> GetShortLeaderBoard(int gameSize, bool teleport) 
    {
        // Get Size List
        var SizeList = GetSpecificSettings(gameSize, teleport);
        
        // Generate Output
        var OutputLeaderBoard = new List<List<string>>();
        int counter = 0;
        foreach (var scoreItem in SizeList)
        {
            OutputLeaderBoard.Add(new List<string>{scoreItem[1] + new string(' ', 10 - scoreItem[0].Length), scoreItem[0]});
            counter++;
            if (counter == 10) break;
        }
        return OutputLeaderBoard;
    }


    private static List<List<string>> GetSpecificSettings(int size, bool teleport)
    {
        var outputList = leaderBoard.FindAll(f => int.Parse(f[2]) == size)
                                    .FindAll(x => bool.Parse(x[3]) == teleport)
                                    .OrderByDescending(s => int.Parse(s[0]))
                                    .ToList();
        return outputList;
    }


    // Load/Save to file
    public static void LoadFile()
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

    public static void SaveToFile()
    {
        string SaveOutput = "";
        foreach (var scoreItem in leaderBoard)
        {
            //              Score : Name : GameSize
            SaveOutput += $"{scoreItem[0]}:{scoreItem[1]}:{scoreItem[2]}:{scoreItem[3]}";
            SaveOutput += "\n";
        }
        File.WriteAllText(fileName, SaveOutput);
    }
}
