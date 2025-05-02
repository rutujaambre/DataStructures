LinkList list1 = new LinkList();
list1.Add(29);
list1.Add(73);
list1.Add(56);
list1.Add(78);
list1.Add(99);
list1.Print();
list1.Search(77);
list1.Search(56);

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data= data;
        Next = null;
    }
}

class LinkList
{
    Node head = null;

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        Node temp= head;
        while (temp.Next != null) {   
            temp = temp.Next;   
        }
        temp.Next = newNode;            //attach new node to the list
    }

    //SEARCH IN LINKEDLIST

    public void Search(int value)
    {
        Node temp = head;
        int posn = 1;

        while (temp != null)
        {
            if (temp.Data == value)
            {
                Console.WriteLine("Found at position: " + posn);
                return;
            }
            temp = temp.Next;
            posn++;
        }

        Console.WriteLine("Value not found in the list.");
        
    }

    public void Print()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data+"-->");
            temp=temp.Next;
        }
        Console.WriteLine("End");

    }

}