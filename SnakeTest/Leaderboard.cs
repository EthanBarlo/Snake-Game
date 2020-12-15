
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

        // Sort List
        //var SortedList = SizeList.OrderBy(int.Parse(SizeList[0]));

        // Generate Output
        var OutputLeaderBoard = new List<string>();
        foreach (var scoreItem in SizeList)
        {
            OutputLeaderBoard.Add($"{scoreItem[0]}  -  {scoreItem[1]}");
        }
        return OutputLeaderBoard;
    }


    private static IEnumerable<List<string>> GetSpecificSize(int size)
    {
        //var outputList = new List<string>();

        //var outputList = leaderBoard.Select(s => s.Select(n => new { Item = n, Size = int.Parse(n.Split(':')[0]) })
        //                            .Where(x => x.Size == size)
        //                            .Select(x => x.Item))
        //                            .ToList();

        var outputList = leaderBoard.Select(s => new { ScoreItem = s, GameSize = int.Parse(s[2]) })
                                    .Where(x => x.GameSize == size)
                                    .Select(x => x.ScoreItem);
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
            //foreach (var item in scoreItem)
            //{
            //    SaveOutput += item;
            //}
            SaveOutput += $"{scoreItem[0]}:{scoreItem[1]}:{scoreItem[2]}";
            SaveOutput += "\n";
        }
        File.WriteAllText(fileName, SaveOutput);
    }
}
