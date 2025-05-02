
LinkedList list = new LinkedList();             // create link list
list.Insert(10);
list.Insert(20);
list.Insert(30);
list.Insert(40);
list.Insert(50);
Console.WriteLine("Original List:");
list.PrintList();

Console.WriteLine("List after insert at start:");
list.InsertAtStart(120);
list.PrintList();

Console.WriteLine("List after insert at end:");
list.InsertAtEnd(150);
list.PrintList();

list.InsertAtPosn(99, 3);
Console.WriteLine($"List after insert at anyposn:");
list.PrintList();

list.InsertAtPosn(111, 20);
list.PrintList();

Console.ReadLine();
class Node                                          //create node
{
    public int Data;                                  //node data 
    public Node Next;                                   //next node reference

    public Node(int data)                               //const to accepte data value
    {
        Data = data;
        Next = null;                                    //initially empty
    }
}

class LinkedList
{
    Node head = null;                           //initially empty

    //CREATE LINKLIST
    public void Insert(int data)                //method to insert data in node
    {
        Node newNode = new Node(data);      //create new node
        if (head == null)                   //chk if head is empty
        {
            head = newNode;                 //true:assign new node ref to head
            return;                            //done
        }

        Node temp = head;                       //false:create temporary node that will start from head i.e 1st node ref
        while (temp.Next != null)               //until last node is found
        {
            temp = temp.Next;                   //move to next
        }
        temp.Next = newNode;                //loop fail:add node to list

        
}       
    //ADD TO START IN EXISTING LL
    public void InsertAtStart(int data)
    {
        Node newNode = new Node(data);      //120 came with next
        newNode.Next = head;                //its next took add of 10 from head & went there
        head = newNode;                     //head took add of 120
    }

    //ADD AT END IN EXISTING LL
    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);  //150 came with next
        newNode.Next = null;
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    //ADD AT GIVEN POSITION
    public void InsertAtPosn(int data,int posn)
    {
        Node newNode = new Node(data);
        if (posn == 1)                                  //posn=1,insert at start
        {
            newNode.Next = head;                        //Point new node to current head as it goes to posn2
            head = newNode;                             //Make new node the new head as it became 1st by pushing 1 to 2
            return;
        }
        
        Node temp = head;                                   // Start from the head to find (posn-1)node
                                                            //to insert at 3posn we have to stop at posn2 
        for (int i = 1; i < posn - 1 && temp != null; i++)
        {
            temp = temp.Next;                           // Move to next node
        }

        if (temp == null)                               //temp=null,position=invalid
        {
            Console.WriteLine("Invalid position");
            return;
        }

        // [1|2a]-[2|3a]-[3|4a]-[4|null] -------------------->//at (posn-1):@2-2.next=temp.next=3a
                                                              //make newnode point to tempnext i.e pt to add of 2's old next
        newNode.Next = temp.Next;                             //temp = 2:stop,temp.next = 3a =>
                                                              //nn.next=3a(hold your next node add as it came in btwn)
       
        
        temp.Next = newNode;        //link temp to new node as temp at posn2 should have add of 3 &
                                                          //at3 newnode inserted

        //[1|2a]-[2|nn.a]-[nndata|3a]-[3|41]-[4|null]
    } 


    public void PrintList()
    {
        Node temp = head;                       //start from head ref
        while (temp != null)                    //until last node found
        {
            Console.Write(temp.Data + " --> ");     //print curret node data
            temp = temp.Next;                       //move to next node
        }
        Console.WriteLine("End");                   //loop fail:end of list
    }


}

