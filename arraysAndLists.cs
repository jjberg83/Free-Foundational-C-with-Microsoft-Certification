int[] startingNumbers = new int[3]{14,2,8};
string[] colors = { "red", "green", "blue" };
int[] scores = new int[4];
List<bool> truths = new List<bool> {true, false,false,true,false};

foreach(int number in startingNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-------------------");

foreach(string color in colors)
{
    Console.WriteLine(color);
}

Console.WriteLine("-------------------");

foreach(int score in scores)
{
    Console.WriteLine(scores);
}

Console.WriteLine("-------------------");

foreach(bool truth in truths)
{
    Console.WriteLine(truth);
}

