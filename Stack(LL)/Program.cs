StackLL stack1 = new StackLL();
stack1.Push(10);
stack1.Push(20);
stack1.Push(30);
stack1.Push(50);
stack1.Pop();
stack1.Peek();
stack1.IsEmpty();
stack1.Push(100);
stack1.Display();
stack1.Count();

class Node
{
    public int data;
    public Node Next;

    public Node(int value)
    {
        data = value;
        Next = null;
    }
}

class StackLL
{
    private Node Top = null;

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = Top;
        Top = newNode;
        Console.WriteLine($"Pushed:{newNode.data}");

    }

    public void Pop()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        int popped = Top.data;
        Top = Top.Next;
        Console.WriteLine($"Popped: {popped}");
    }

    public int Peek()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack Empty");
            return -1;
        }
        Console.WriteLine($"Peek: {Top.data}");
        return Top.data;
    }

    public bool IsEmpty()
    {
        bool empty = (Top == null);
        Console.WriteLine($"Is Empty: {empty}");
        return empty;
    }

    public int Count()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack Empty");
        }
        int count = 0;
        Node temp = Top;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        Console.WriteLine($"Count: {count}");
        return count;
    }

    public void Display()
    {
        if (Top == null)
        {
            Console.WriteLine("Stack Empty");
            return;
        }
        Console.WriteLine("Stack Items:");
        Node temp = Top;
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.Next;
        }
    }
}