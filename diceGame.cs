using System.Linq.Expressions;

Console.WriteLine("How many times do you want to throw the dice?");
try
{
    int timesToPlay = Convert.ToInt32(Console.ReadLine()); 
    int doubles = 0;
    int triples = 0;
    // Display the final result
    for(int i = 0; i < timesToPlay; i++)
    {
        // Roll the dice
        Random random = new Random();
        int rollOne = random.Next(1,7);
        int rollTwo = random.Next(1,7);
        int rollThree = random.Next(1,7);

        int total = 0;

        // Award a bonus for doubles or triples
        int bonusNew;
        if ((rollOne == rollTwo) && (rollOne == rollThree))
        {
            bonusNew = 20;
            triples++;
        }
        else if ((rollOne == rollTwo) || (rollTwo == rollThree) || (rollOne == rollThree))
        {
            bonusNew = 10;
            doubles++;
        }
        else
        {
            bonusNew = 0;
        }

        // Display the roll and total
        Console.WriteLine($@"
        Roll one: {rollOne}
        Roll two: {rollTwo}
        Roll three: {rollThree}
        Bonus: {bonusNew}
        Total: {total += rollOne + rollTwo + rollThree + bonusNew}
        ###############################");    
    }
    Console.WriteLine($@"
    Doubles: {doubles}
    Triples: {triples}");
}
catch
{
    Console.WriteLine("Please enter a number");
}

