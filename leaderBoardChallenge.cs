 // Set up the game
Random random = new Random();
int roundsPlayed = 8;
List<int> allScores = new List<int>();

Console.WriteLine($"Playing {roundsPlayed} rounds...\n");

// Simulate playing rounds and log every score
for (int round = 1; round <= roundsPlayed; round++)
{
    int score = random.Next(0, 101);
    allScores.Add(score);
    Console.WriteLine($"Round {round}: scored {score} points");
}

Console.WriteLine($"\nTotal rounds logged: {allScores.Count}");

// Build the Top 5 leaderboard array
int[] top5Leaderboard = new int[5];
allScores.Sort();
// foreach(int score in top5Leaderboard)
// {
    
// }
for(int i = 0; i < 5; i++)
{
    top5Leaderboard[i] = allScores[allScores.Count - (i+1)];
}
// Console.WriteLine(allScores[allScores.Count -1]);
// Console.WriteLine(allScores[allScores.Count -2]);
// Console.WriteLine(allScores[allScores.Count -3]);

foreach(int score in top5Leaderboard)
{
    Console.WriteLine(score);
}
// Print the leaderboard