
            //INSERTION IN LINKEDLIST FROM START 
LinkedList list = new LinkedList();
list.InsertAtStart(10);
list.InsertAtStart(20);
list.InsertAtStart(30);
list.PrintList();
Console.ReadLine();

class Node                      // defines node
{
    public int Data;            //data od node
    public Node Next;           //points to the next node  (reference)

    public Node(int data)       //constructor(create a new node with given data)
    {
        Data = data;            //will set datapart in node to passed value
        Next = null;            //will store add of next node but initially null because empty
    }
}

class LinkedList                //new class LinkedList
{
    private Node head;         //head=firstnode address holder

    public LinkedList()
    {
        head = null;            //initially empty
    }

    public void InsertAtStart(int data)     //methods to insert data at start data(30)..>(10)..>(20)
    {
        Node newNode = new Node(data);      //created new node with given data.(object of class node)
        newNode.Next = head;                //newnode point to exact next node(initilaay to head  beacuse head is null &
                                            //since its 1st node and has next as null so null from head is set to it &
                                            //later head gets its value from 1st node i.e newNode
                                            //head[20.add]-->[20|10.add]-->[10|null]         
       
        
        head = newNode;                     //head pointing to new node head[10.add] then 20 added so
                                            //[20.add]--[20|10.add]--[10|null}
    }

    public void PrintList()                     //prints llist from start to end.
    {
        Node current = head;                    //start from head node
        while (current != null)                 //until current isnot null
        {
            Console.Write(current.Data + " -> ");   //print current data
            current = current.Next;                 //move to next node
        }
        Console.WriteLine("End");
    }
}

  
