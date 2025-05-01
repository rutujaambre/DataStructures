
char[] letters = { 'a', 'e', 'i', 'o', 'u', 'e' };          //character array
int count=letters.Length;                                   //check length
Console.WriteLine("Original Array:");
foreach(char c in letters)
{
    Console.WriteLine(c);                           //print array
}
for(int i = 0; i < count; i++)                          //loop through array
{
    if (letters[i] == 'e')                          //check if e
    {
        for (int j = i; j < count - 1; j++)     //to Performs the shifting 
        {
            letters[j]=letters[j + 1];          //actual shift left
        }
        count--;                        //decrease logical count to reduce unnecessary looping
        i--;                                // rechecks the shifted index to ensure no ele skipped
    }
}
Console.WriteLine("Array after deletion:");
for (int i = 0; i < count; i++)
{
    Console.Write(letters[i] + " ");                //print array after deletion
}
