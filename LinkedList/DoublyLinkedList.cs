
namespace LinkedList
{

    public class Node
    {
        public int Data;
        public Node Next;
        public Node Prev;
        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }


    public class DoublyLinkedList
    {
        private Node head;

        public void InsertAtHead(int data)
        {
            Node newNode = new Node(data);

            if (head != null)
            {
                newNode.Next = head;
                head.Prev = newNode;
            }
            head = newNode;
        }

        public void DisplayList()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;

            }
            Console.Write("null");

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
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Prev = head;
        }

        
    }
}
