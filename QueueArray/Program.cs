
QueueArray queue1 = new QueueArray(3);
queue1.Enqueu(99);
queue1.Enqueu(100);
queue1.Enqueu(1111);
queue1.Display();
queue1.IsFull();
queue1.Dequeu();
queue1.Peek();
queue1.Count();
queue1.IsEmpty();
queue1.Display();

public class QueueArray
{
    private int[] Queue;
    private int front;
    private int rear;
    private int capacity;

    public QueueArray(int size)
    {
        capacity = size;
        front = -1;
        rear = -1;
        Queue = new int[capacity];
    }

    public void Enqueu(int value)
    {
        if (rear == capacity - 1)
        {
            Console.WriteLine("Queue is Full");
            return;
        }
        else if (front == -1 && rear == -1)
        {
            front++;
            rear++;
            Queue[rear] = value;
            Console.WriteLine($"Enqued:{value}");
        }
        else
        {
            Queue[++rear] = value;
            Console.WriteLine($"Enqued:{value}");

        }
    }

    public void Dequeu()
    {
        if (rear == -1 && front == -1)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        Console.WriteLine($"Dequqed:{Queue[front]}");
        front++;
    }

    public int Peek()
    {
        if (rear == -1 && front == -1)
        {
            Console.WriteLine("Queue is Empty");
            return -1;
        }
        Console.WriteLine($"Peek: {Queue[front]}");
        return front;
    }
    public bool IsEmpty()
    {
        bool empty = (front == -1 && rear == -1);
        Console.WriteLine($"Is Empty: {empty}");
        return empty;
    }

    public bool IsFull()
    {
        bool full = (rear == capacity - 1);
        Console.WriteLine($"Is Full:{full}");
        return full;
    }

    public int Count()
    {
        if (front == -1 && rear == -1)
        {
            Console.WriteLine("Queue Empty");
        }
        int count = rear-front+ 1;
        Console.WriteLine($"No of Queue Elements:{count}");
        return count;
    }

    public void Display()
    {
        if (front == -1 && rear== -1)
        {
            Console.WriteLine("Queue Empty");
        }
        else
        {
            Console.WriteLine("Queue Items:");
            for (int i = front; i <= rear ; i++)
            {
                Console.WriteLine(Queue[i]);
            }
        }
    }
  
}



