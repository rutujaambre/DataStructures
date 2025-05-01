//INSERTION IN ARRAY

//Insertion at END


int[] numbers= new int [7];  //array of size 7
numbers[0] = 76;
numbers[1] = 59;
numbers[2] = 38;
numbers[3] = 84;
numbers[4] = 73;
//numbers[5] = 64;
//numbers[6] = 88;

int count = 5;   //5 elements stored in array
Console.WriteLine("Elements in array before insertion:");

foreach (int i in numbers){
   Console.Write(i+" ");
}

Console.WriteLine($"Total size of array:{numbers.Length} & Number of elemets in array:{count}");

//ADD ELEMENT AT END OF EXISITING ARRAY ELEMENT
int newno = 84;             //new ele to add in array

if (count < numbers.Length)
{
    numbers[count] = newno;     //insert new ele in numbers array at index of count(becausecount=5;ele till 4 index so next
                                //position empty at end of array=5=count)
    count++;                    //new ele added

    Console.WriteLine("Elelments after insertion at end:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }

}
else
{
    Console.WriteLine("No Space Available..Can't perform Isertion");
}

//ADD ELEMENT AT END OF THE ORIGINAL ARRAY because element 2 empty

int no = 99;
if (count < numbers.Length)
{
    numbers[numbers.Length - 1] = no;
    count++;

    Console.WriteLine("Elelments after insertion at end of array:");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine($"Total size of array:{numbers.Length} & Number of elemets in array:{count}");
}
else
{
    Console.WriteLine("No Space Available..Can't perform Isertion");
}



// INSERT ELEMENT AT ANY MID INDEX OF ARRAY

int ele = 74;                                   //insert value
int idx = 2;                                    //insert posn index

if (count < numbers.Length)                     //check if space avail in array
{
    for (int i = count - 1; i >= idx; i--)       //iterates array till posn2:idx2
    {
        numbers[i + 1] = numbers[i];                //right shift elements till 2 posn ele is shifted
    }
    numbers[idx] = ele;                         //2nd ele shifted so insert new ele at desired place
    count++;                                    //update count of arr ele

    Console.WriteLine($"Elements after insertion at index {idx}:");
    foreach (int i in numbers)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.WriteLine("No Space Available for insertion in Array");
}



//ADD ELE AT BEGINNING OF ARRAY

int newNo = 123;
if (count < numbers.Length)
{
    for (int i = count; i >= 0; i--)
    {
        numbers[i + 1] = numbers[i];
    }

    numbers[0] = newNo;
    count++;

    Console.WriteLine("Elements in array after insertion at beginning:");
    foreach (int i in numbers)
    {
        Console.Write(i + " ");
    }
}
else
{
    Console.WriteLine("No Space available for elements to shift..No Insertion ca be performed");
}