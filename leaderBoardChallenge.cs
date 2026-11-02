 // Set up the game
Random random = new Random();
int roundsPlayed = 10;
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

// Build the Top 5 leaderboard array and print it
int[] top5Leaderboard = new int[5];
allScores.Sort();

// Finn ut hvor høy minste indeks kan være på listen og arrayen
// Man må finne en slik felles høyeste indeks, siden de to "samarbeider"
// Kan aldri være større enn 5, siden arrayens lengde er det
int highestCommonIndex = Math.Min(allScores.Count, top5Leaderboard.Length); 

 Console.WriteLine($"\n🏆 Top {highestCommonIndex} Leaderboard 🏆\n --------------------------");
 // Se emojier her:
 // https://emojipedia.org/
 // Bare husk å ta quotes rundt dem
//  Console.WriteLine("🎃");
//  Console.WriteLine("🥹");

// Eksempler på alignment in string interpolation her:
// Bruker denne teknikken for å style scoreboardet i terminalen
// Console.WriteLine($"[{42,5}]");    // [   42]
// Console.WriteLine($"[{42,-5}]");   // [42   ]
// Console.WriteLine($"[{"Ann",-6}]"); // [Ann   ]
Console.WriteLine($"{"Position", -3} {"Scores", 8}");
for(int i = 0; i < highestCommonIndex; i++)
{
    top5Leaderboard[i] = allScores[allScores.Count - (i+1)];
    Console.WriteLine($"{i + 1 + ":", -10} {top5Leaderboard[i], 1}");
}





