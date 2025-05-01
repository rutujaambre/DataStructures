
StackArray s1 = new StackArray(5);
s1.Push(10);
s1.Push(20);
s1.Push(30);
s1.Push(50);
s1.Pop();
s1.Peek();
s1.IsEmpty();
s1.Push(100);
s1.Display();
s1.Count();




public class StackArray                 //class to create stack
{
    private int[] Stack1;               //private var hide internal details
    private int capacity;              //Prevents unauthorized access or modification of stack data.
    private int top;

    public StackArray(int size)             //creation of custom-sized stacks.
    {
        capacity = size;                    //Copies input to internal field for reuse
        Stack1 = new int[capacity];         //Creates array with the defined stack size
        top = -1;                           //confirm empty stack
    }

    public void Push(int value)
    {
        if (top == capacity - 1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        } 
        Stack1[++top] = value;
        Console.WriteLine($"Pushed:{value}");
    }

    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        int popped=Stack1[top--];
        Console.WriteLine($"Popped:{popped}");
    }

    public int Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Empty");
            return -1;                          //ret default value on empty
        }
        Console.WriteLine($"Peek: {Stack1[top]}");
        return Stack1[top];
    }
    public bool IsEmpty()
    {
        bool empty = (top == -1);
        Console.WriteLine($"Is Empty: {empty}");
        return empty;
    }
    public int Count()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Empty");
        }
        int count = top + 1;
        Console.WriteLine($"Count: {count}");
        return count;
    }
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Empty");
        }
        else
        {
            Console.WriteLine("Stack Items:");
            for (int i = top; i >= 0; i--)
            {

                Console.WriteLine(Stack1[i]);
            }
        }
    }
}

////Without Constructor

//int[] stack = new int[3];
//int top = -1;

//void Push(int value)
//{
//    if (top >= stack.Length - 1)
//    {
//        Console.WriteLine("Stack Overflow!");
//        return;
//    }

//    stack[++top] = value;
//    Console.WriteLine($"Pushed {value}");
//}

//int Pop()
//{
//    if (top == -1)
//    {
//        Console.WriteLine("Stack Underflow!");
//        return -1;
//    }

//    return stack[top--];
//}


//Push(11);
//Push(22);
//Push(33);
//Push(44); // Overflow

//Console.WriteLine("Popped: " + Pop()); // 33
//Console.WriteLine("Popped: " + Pop()); // 22
//Console.WriteLine("Popped: " + Pop()); // 11
//Console.WriteLine("Popped: " + Pop()); // Underflow




