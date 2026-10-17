
 // Display the final result
 for(int i = 0; i <= 100; i++)
{
    
    // Roll the dice
    int rollOne = new Random().Next(1,7);
    int rollTwo = new Random().Next(1,7);
    int rollThree = new Random().Next(1,7);

    int total = 0;

    // Award a bonus for doubles or triples
    int bonusNew = (
        (rollOne == rollTwo) ||
        (rollTwo == rollThree) ||
        (rollOne == rollThree) ||
         (((rollOne + rollTwo + rollThree) %3) == 0)
    ) ? 10 : 0;

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
