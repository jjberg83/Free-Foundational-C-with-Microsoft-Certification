// Generate a random number of days until expiration
Random random = new Random();
int daysUntilExpiration = random.Next(12);
Console.WriteLine(daysUntilExpiration);
int discountPercentage = 0;

// Display an expiration message based on the days remaining
if(daysUntilExpiration == 0)
{
    Console.WriteLine($@"Your subscription has expired.");
    discountPercentage = 30;
}
else if(daysUntilExpiration == 1)
{
    Console.WriteLine($@"Your subscription expires within a day!");
    discountPercentage = 20;
}
// denne sjekken er implisitt, og i mine øyne helt åpenbar. Man vet at daysUntilExpiration > 1, pga sjekken over
// men fikk en challenge der vi skulle gjøre det eksplisitt, så derfor endrer jeg den
// else if(daysUntilExpiration <= 5)
else if(daysUntilExpiration > 1 && daysUntilExpiration <= 5)
{
    Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if(daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// switch(daysUntilExpiration)
// {
//     case 0:
//         Console.WriteLine($@"Your subscription has expired.");
//         break;
//     case 1:
//         Console.WriteLine($@"Your subscription expires within a day!");
//         discountPercentage = 20;
//         break;
//     case <= 5:
//         Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.");
//         discountPercentage = 10;
//         break;
//     default:
//         Console.WriteLine("Your subscription will expire soon. Renew now!");
//         break;   
// }

// Display a discount message if a discount applies
if(discountPercentage > 0)
{
    Console.WriteLine($"You have a discount of {discountPercentage}%!");
}