
LinkedList list = new LinkedList();             // create link list
list.Insert(10);
list.Insert(20);
list.Insert(30);
list.Insert(40);
list.Insert(50);

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
        temp.Next = newNode;                    //loop fail:add node to list
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

