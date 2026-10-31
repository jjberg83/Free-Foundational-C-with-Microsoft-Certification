// Set up the game
Random random = new Random();
int secretNumber = random.Next(1,21);
int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;

Console.WriteLine("Guess a number betweeen 1 and 20");
Console.WriteLine($"You have {maxGuesses} guesses");

// Ask the player to guess
while(guessCount < maxGuesses)
{
    string playersInput = Console.ReadLine();
    bool guessValid = int.TryParse(playersInput, out int playersGuess);
    guessCount++;

    // Check the guess and give feedback
    if(playersGuess == secretNumber)
    {
        Console.WriteLine($"Wow, you nailed it! You guessed {playersGuess}, which is correct!");
        break;
    }
    else
    {
        Console.WriteLine($"Sorry, {playersGuess} was not the correct number. You have {guessCount} more guesses - try again!");
    }
}

    

// Announce the result
Console.WriteLine($"You made {guessCount} guesses.");