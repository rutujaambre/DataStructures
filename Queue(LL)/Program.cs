
QueueLL queue1 = new QueueLL();
queue1.Enqueu(99);
queue1.Enqueu(100);
queue1.Enqueu(1111);
queue1.IsFull();
queue1.Dequeu();
queue1.Peek();
queue1.Count();
queue1.IsEmpty();
queue1.Display();


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

class QueueLL
{
    private Node front;
    private Node rear;
    public QueueLL()
    {
        front = null;
        rear = null;
    }

    public void Enqueu(int value)
    {
        Node newNode = new Node(value);
        if (front == null && rear == null)
        {
            front = rear = newNode;
            Console.WriteLine($"Enqued: {value}");
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
            Console.WriteLine($"Enqued: {value}");
        }
    }

    public void Dequeu()
    {
        if (front == null && rear == null)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        Console.WriteLine($"Dequqed: {front.data}");
        front = front.Next;

        if (front == null)
            rear = null;
    }

    public int Peek()
    {
        if (front == null && rear == null)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        Console.WriteLine($"Peek: {front.data}");
        return front.data;
    }

    public bool IsEmpty()
    {
        bool empty = (front == null && rear == null);
        Console.WriteLine($"Is Empty: {empty}");
        return empty;
    }

    public bool IsFull()
    {                                                                                                               
        Console.WriteLine("Is Full: False");    //grow dynamically so never full unless out-of-memory so FALSE ALWAYS      
        return false;
    }

    public int Count()
    {
        if (front == null && rear == null)
        {
            Console.WriteLine("Queue Empty");
            return 0;
        }
        int count = 0;
        Node current = front;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        Console.WriteLine($"No of Queue Elements: {count}");
        return count;
    }

    public void Display()
    {
        if (front == null && rear == null)
        {
            Console.WriteLine("Queue Empty");
            return;
        }

        Console.WriteLine("Queue Items:");
        Node current = front;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.Next;
        }
    }



}