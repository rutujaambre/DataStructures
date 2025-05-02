
Linkedlist newlist = new Linkedlist();
newlist.Add(23);
newlist.Add(46);
newlist.Add(73);
newlist.Add(18);
newlist.Add(68);
newlist.Add(98);
Console.WriteLine("Original LL:");
newlist.PrintList();
Console.WriteLine("Deleting start node:");
newlist.DeleteAtStart();
newlist.PrintList();
Console.WriteLine("Deleting end node:");
newlist.DeleteAtEnd();
newlist.PrintList();
Console.WriteLine("Deleting specific node:");
newlist.DeleteAtPosn(2);
newlist.PrintList();
Console.WriteLine("Deleting specific node:");
newlist.DeleteAtPosn(42);
newlist.PrintList();


class Node
{
    public int data;
    public Node Next;

    public Node(int Data)
    {
        data = Data;
        Next = null;
    }
}
class Linkedlist
{
     Node head=null;

    public void Add(int Data)
    {
        Node newnode = new Node(Data);
        if (head == null)
        {
            head = newnode;
            return;
        }
        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newnode;

    }

    //DELETE FROM START

    public void DeleteAtStart()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        head = head.Next; // set head to next node
    }

    //DELETE FROM END

    public void DeleteAtEnd()
    {
        if (head == null)                   //empty
        {
            Console.WriteLine("List is empty");
            return;
        }
        if (head.Next == null)
        {
            head = null;                //only one node
            return;
        }

        Node temp = head;
        while (temp.Next.Next != null)      //next-to-next
        {
            temp = temp.Next;               //stop at second last
        }

        temp.Next = null;                   //remove last
    }

    public void DeleteAtPosn(int posn)
    {
        if (posn < 1)
        {
            Console.WriteLine("Invalid Position");
            return;
        }
        if (head == null) {
            Console.WriteLine("List is Empty");
            return;
        }
        if (posn == 1){
            head=head.Next;
            return;
        }
        Node temp = head;
        for (int i = 1; i < posn - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null || temp.Next == null)
        {
            Console.WriteLine("NO Such Node:Invalid position");
            return;
        }

        temp.Next = temp.Next.Next;

    }



    public void PrintList()
    {
        Node temp = head;                       
        while (temp != null)                    
        {
            Console.Write(temp.data + " --> ");     
            temp = temp.Next;                       
        }
        Console.WriteLine("End");                   
    }
}
