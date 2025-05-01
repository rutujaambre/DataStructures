//UPDATE PARTICULAR ELEMENT
string[] fruits = new string[6];
fruits[0] = "mango";
fruits[1] = "fig";
fruits[2] = "apple";
fruits[3] = "berry";
fruits[4] = "papaya";
fruits[5] = "apple";

Console.WriteLine("Original Array:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

//UPDATE ONLY 1ST OCCURANCE
for (int i = 0; i < fruits.Length; i++)
{
    if (fruits[i] == "apple")
    {
        fruits[i] = "Banana";
        break;
    }
}
Console.WriteLine("Updated 1st occurance of apple to Banana");
Console.WriteLine("Updated Fruit Array:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

//UPDATE ALL OCCURANCES
for (int i = 0; i < fruits.Length; i++)
{
    if (fruits[i] == "apple")
    {
        fruits[i] = "Banana";
    }
}
Console.WriteLine("Updated all occurance of apple to Banana");
Console.WriteLine("Updated Fruit Array:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}


//UPDATE START ELEMENT

int[] numbers = { 10, 20, 30, 40, 50 };     //array
Console.Write("Original Array:");
foreach (int num in numbers)
{
    Console.WriteLine(num + " ");
}

int newValue = 999;
numbers[0] = newValue;


Console.WriteLine("Updated Array:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}


