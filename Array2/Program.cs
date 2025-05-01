
string[] colours = { "red", "pink", "blue", "green", "yellow" };

//TRAVERSAL

for (int i = 0; i < colours.Length;i++)
{
    Console.WriteLine(colours[i]);
}

foreach (var colour in colours)
{
    Console.WriteLine(colour);
}

for (int i = 0; i < colours.Length; i++)
{
    Console.WriteLine($"Index:{i}:{colours[i]}");
}


