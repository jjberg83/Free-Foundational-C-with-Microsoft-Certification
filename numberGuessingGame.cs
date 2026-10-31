// Set up the game
Random random = new Random();
int maxNumber = 20;
int secretNumber = random.Next(1,maxNumber + 1);
int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;

Console.WriteLine($"Guess a number betweeen 1 and {maxNumber}");
Console.WriteLine($"You have {maxGuesses} guesses");

// Ask the player to guess
while(guessCount < maxGuesses)
{

    int playersGuess;
    while(!int.TryParse(Console.ReadLine(), out playersGuess) || playersGuess < 1 || playersGuess > 20)
    {
        Console.WriteLine($"Please enter a number between 1 and {maxNumber}");
    }
    guessCount++;

    // Check the guess and give feedback
    if(playersGuess == secretNumber)
    {
        hasWon = true;
        Console.WriteLine($"Wow, you nailed it! ");
        break;
    }
    else if(playersGuess > secretNumber)
    {
        Console.WriteLine($"The correct number is lower. You have {maxGuesses - guessCount} guesses left!");
    }
    else if (playersGuess < secretNumber)
    {
        Console.WriteLine($"The correct number is higher. You have {maxGuesses - guessCount} guesses left!");
    }
}

    

// Announce the result
if(hasWon)
{
    Console.WriteLine($"You won, and guessed the correct number after {guessCount} guesses!");
}
else
{
    Console.WriteLine($"You lost - no more guesses left!");
}