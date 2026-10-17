
 // Display the final result
 for(int i = 0; i <= 100; i++)
{
    // Roll the dice
    Random random = new Random();
    int rollOne = random.Next(1,7);
    int rollTwo = random.Next(1,7);
    int rollThree = random.Next(1,7);

    int total = 0;

    // Award a bonus for doubles or triples
    int bonusNew = 
        ((rollOne == rollTwo) && (rollOne == rollThree)) ? 20 :
        (
            (rollOne == rollTwo) ||
            (rollTwo == rollThree) ||
            (rollOne == rollThree)
        ) ? 10 :
        0;

    int bonus = 0;

    // Display the roll and total
    Console.WriteLine($@"
    Roll one: {rollOne}
    Roll two: {rollTwo}
    Roll three: {rollThree}
    Bonus: {bonusNew}
    Total: {total += rollOne + rollTwo + rollThree + bonusNew}
    ###############################");    
}
