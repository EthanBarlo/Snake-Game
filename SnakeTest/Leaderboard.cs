
using System.Collections.Generic;
using System.IO;
using System.Linq;


static class Leaderboard
{
    // Attributes
    private static string fileName = "leaderBoard.txt";
    public static List<List<string>> leaderBoard;
    
    


    // Edit Leaderboard
    public static void addNewScore(int score, string name)
    {
        leaderBoard.Add(new List<string>  { score.ToString(), name });
    }


    //Get leaderBoard
    public static List<string> GetLeaderBoard() 
    {
        // Need to improve so it gets the leaderboard for specific stats
        // e.g. Hard, Easy. Small, Large. Fast, Slow
        var OutputLeaderBoard = new List<string>();
        foreach (var scoreItem in leaderBoard)
        {
            OutputLeaderBoard.Add($"{scoreItem[0]}  -  {scoreItem[1]}");
        }
        return OutputLeaderBoard;
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
            foreach (var item in scoreItem)
            {
                SaveOutput += item;
            }
            SaveOutput += "\n";
        }
        File.WriteAllText(fileName, SaveOutput);
    }
}
