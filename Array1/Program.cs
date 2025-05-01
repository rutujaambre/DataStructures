
//Array Initilization & Declaration ways:

int[] arr1;                   //Declaration
arr1 = new int[10];           //Initilization

char[] arr2 = new char[4];        //decln+mem.allocation
arr2[0] = 'e';
arr2[1] = 'r';
arr2[2] = 't';
arr2[3] = 'd';
for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}

int[] arr3 = { 1, 2, 3, 7, 4 };         //decln+ini.

string[] name = new string[] { "rutuja", "sakshi", "nikita" };    //decln+ini.

int[] numbers = new int[3] { 3, 4, 5 };       //decln+ini.
