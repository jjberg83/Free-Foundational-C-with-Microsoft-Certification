 // Prøver å generere samme rekke flere ganger, siden man starter med samme see
 // Dokumentasjon her:
 // https://learn.microsoft.com/en-us/dotnet/api/system.random.-ctor?view=net-10.0#system-random-ctor(system-int32)
 
Random random = new Random(42); // Always starts with the same seed, so the sequence will remain the same

for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Console.Write($"{random.Next(1,10)}");
        if(j==4)
        {
            Console.WriteLine();
        }
    }
    Console.WriteLine("---------------");
}