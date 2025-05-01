//STRING ARRAY

string[] fruits = new string[] { "Apple", "Banana", "Orange", "Mango", "Pineapple" };

Console.WriteLine("Original Array:");           // Print the original array
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit + " ");
}

Console.WriteLine();

Console.WriteLine("\nElement at index 2: " + fruits[2]);    //// Accessing an element by index

fruits[1] = "Blueberry";
Console.WriteLine("Array after changing index 1:");         // Changing an element at index 1
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit + " ");
}

Console.WriteLine();

Console.WriteLine("Length of the array: " + fruits.Length);   // Get the length of the array

Array.Sort(fruits);
Console.WriteLine("Array after sorting:");      // Sorting the array
foreach (string fruit in fruits)
{
    Console.Write(fruit + " ");
}

Console.WriteLine();

Array.Reverse(fruits);
Console.WriteLine("Array after reversing:");      //// Reversing the array
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit + " ");
}

Console.WriteLine();

// Searching for an element (checking if "Mango" exists)
int index = Array.IndexOf(fruits, "Mango");
if (index >= 0)
    Console.WriteLine("'Mango' found at index: " + index);
else
    Console.WriteLine("'Mango' not found in the array.");

string[] fruitsCopy = new string[fruits.Length];                // Copying the array into another array
Array.Copy(fruits, fruitsCopy, fruits.Length);
Console.WriteLine("\nArray copied:");
foreach (var fruit in fruitsCopy)
{
    Console.Write(fruit + " ");
}


