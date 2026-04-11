
public class Node
{
    public int Data;
    public Node prev;
    public Node next;
    public Node(int data)
    {
        Data = data;
        prev = null;
        next = null;
    }
} 
public class PracticeDLL
{
    public Node head;

    public void InsertAtHead(int data)
    {
        Node newNode = new Node(data);
        if(head == null)
        {
            head = newNode;
            return;
        }
        newNode.next = head;
        head.prev = newNode;
        head = newNode;
    }
    public void InsertAtTail(int data)
    {
        Node newNode = new Node(data);
        if(head == null)
        {
            head = newNode;
            return;
        }
        Node temp = head;
        while(temp != null)
        {
            temp = temp.next;
        }
        temp.next = newNode;
        newNode.prev = temp;
    }

    public void InsertAtPosition(int pos, int data)
    {
        Node newNode = new Node(data);
        if(pos == 0)
        {
            if(head == null)                //InsertAtHead();
            {
                head = newNode;
                return;
            }

            newNode.next = head;
            head.prev = newNode;
            head = newNode;
            //return;
        }
        if(pos < 0)
        {
            Console.WriteLine("Invalid Position");
            return;
        }
        Node temp = head;
        for(int i=0; i < pos - 1; i++)
        {
            if(temp == null)
            {
                Console.WriteLine("Position is out of range:");
                return;
            }
            temp = temp.next;
        }

        
        newNode.next = temp.next;
        newNode.prev = temp;
        
        if(temp.next != null)
        {
            temp.next.prev = newNode;
        }
        temp.next = newNode;


    }

    public void DeleteFromHead()
    {
        if (head == null) return;

        if (head.next == null)
        {
            head = null;
            return;
        }

        head = head.next;
        head.prev = null;
    }
    public void DeleteFromTail()
    {
        if (head == null) return;

        if(head.next == null)
        {
            head = null;
            return;
        }

        Node temp = head;

        while(temp.next != null)
        {
            temp = temp.next;
        }

        temp.prev.next = null;

    }

    public void DeleteFromPosition(int pos)
    {
        if(head == null)
        {
            Console.WriteLine("Linked List is empty");
            return;
        }
        if(pos < 0)
        {
            Console.WriteLine("Invalid Position");
            return;
        }
        if(pos == 0)
        {
            DeleteFromHead();
            return;
        }
        Node temp = head;
        for(int i=0;i < pos; i++)
        {
            if(temp == null)
            {
                Console.WriteLine("Index out of range");
                return;
            }
            temp = temp.next;
        }
        if(temp == null)
        {
            Console.WriteLine("Out of Range");
            return;
        }

        if(temp.prev != null)
        {
            temp.prev.next = temp.next;
        }
        if(temp.next != null)
        {
            temp.next.prev = temp.prev;
        }

    }

    public void DisplayFrwd()
    {
        if(head == null)
        {
            Console.WriteLine("Linked List is empty");
            return;
        }
        Node temp = head;
        while(temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.next;
        }
        Console.Write("null");
    }
    public void DisplayBckwd()
    {
        if(head == null)
        {
            Console.WriteLine("LinkedList is empty");
            return;
        }
        Node temp = head;
        while(temp.next != null)
        {
            temp = temp.next;
        }

        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.prev;
        }
        Console.Write("null");
    }

    public void Reverse()
    {
        if (head == null) return;
        Node temp = head;
        Node newHead = null;

        while (temp != null)
        {
            Node swap = temp.next;  // Swaaping Logic ( Between next and prev )
            temp.next = temp.prev;
            temp.prev = swap;

            newHead = temp;        // Update the newHead

            temp = swap;           // Move frwd [ actually backward after swap ]

        }
        head = newHead;
    }




    public void ReverseL()
    {
        if (head == null) return;
        Node temp = head;
        Node newHead = null;
        while (temp != null)
        {
            Node swap = temp.next;
            temp.next = temp.prev;
            temp.prev = swap;

            newHead = temp;
            temp = swap;
        }
        head = newHead;
    }


}
