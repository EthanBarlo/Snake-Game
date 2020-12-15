
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
    public static void addNewScore(string score, string name, int gameSize)
    {
        leaderBoard.Add(new List<string>  {score, name, $"{gameSize}" });
        SaveToFile();
    }


    //Get leaderBoard
    public static List<string> GetShortLeaderBoard(int GameSize) 
    {
        // Get Size List
        var SizeList = GetSpecificSize(GameSize);

        // Generate Output
        var OutputLeaderBoard = new List<string>();
        int counter = 0;
        foreach (var scoreItem in SizeList)
        {
            OutputLeaderBoard.Add($"{scoreItem[0]}-{scoreItem[1]}");
            counter++;
            if (counter == 10) break;
        }

        return OutputLeaderBoard;
    }


    private static List<List<string>> GetSpecificSize(int size)
    {
        var outputList = leaderBoard.FindAll(f => int.Parse(f[2]) == size).OrderBy(s => int.Parse(s[0])).ToList();
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
            SaveOutput += $"{scoreItem[0]}:{scoreItem[1]}:{scoreItem[2]}";
            SaveOutput += "\n";
        }
        File.WriteAllText(fileName, SaveOutput);
    }
}
