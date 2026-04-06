
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
}
