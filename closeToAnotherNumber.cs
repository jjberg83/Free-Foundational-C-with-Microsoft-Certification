decimal first = 5.00m;
decimal second = 6.0m;
decimal third = -5.5m;

decimal tolerance = 1m;

decimal compareFirstAndSecond = Math.Abs(first - second);
decimal compareFirstAndThird = Math.Abs(first - third);

Console.WriteLine(compareFirstAndSecond);
Console.WriteLine(compareFirstAndThird);

if (compareFirstAndSecond > tolerance)
{
    Console.WriteLine("first and second are far away from eachother");
}
if (compareFirstAndThird > tolerance)
{
    Console.WriteLine("first and third are far away from eachother");
}





