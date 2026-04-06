namespace LinkedList
{
    public class ListNode
    {
        public int Data;
        public ListNode Next;
        
        public ListNode(int val)
        {
            Data = val;
            Next = null;
        }
    }
        
    // Create a LinkedList
    public class LinkedList
    {
        private ListNode Head;

        // Add node at beginning

        public void AtBeginning(int data)
        {
            ListNode newNode = new ListNode(data);
            newNode.Next = Head;                    // point to the first node 
            Head = newNode;                         // head point to newNode
        }

        //Add At End
        public void AtEnd(int data)
        {
            ListNode newNode = new ListNode(data);

            // If the LinkedList is empty

            if(Head == null)
            {
                Head = newNode;
                return;
            }
            ListNode temp = Head;
           
            while(temp.Next != null)     // After While loop `temp` will be at last node
            {
                temp = temp.Next;
            }

            temp.Next = newNode;        // Adding the newNode at end (temp at last node after while)

        }

        // Insertion in a  position
        
        public void AtPosition(int data, int pos)
        {
            if (pos < 0)
            {
                Console.WriteLine("Invalid Position");
                return;
            }   
            if(pos == 0)
            {
                AtBeginning(data);
                return;
            }

            ListNode temp = Head;

            for(int i = 0; i < pos - 1; i++)             // To get the position
            {
                if(temp == null)
                {
                    Console.WriteLine("Index out of range");
                    return;
                }
                temp = temp.Next;
            }

            ListNode newNode = new ListNode(data);

            newNode.Next = temp.Next;
            temp.Next = newNode;

        }

        // Display the LinkedList
        
        public void DisplayList()
        {
            if(Head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }

            ListNode temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.Next;
                
            }
                Console.Write("null");
        }
           

        // Delete from Beginning
        
        public void DeleteFromBeginning()
        {
            if(Head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;

            }
            Head = Head.Next;

        }

        // Delete from End

        public void DeleteFromEnd()
        {
            if(Head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            if(Head.Next == null)
            {
                Head = null;
                return;
            }
            ListNode temp = Head;
            while(temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null; 
        }

        // Delete from a position

        public void DeleteAtPosition(int pos)
        {
            if(Head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }


            if (pos < 0)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            if (pos == 0)
            {
                Head = Head.Next;   // DeleteFromBeginning() Method
                return;
            }
            ListNode temp = Head;

            for (int i = 0; i < pos - 1; i++)
            {
                if (temp.Next == null)
                {
                    Console.WriteLine("Position Out of Range");
                    return;
                }
                temp = temp.Next;
            }
            if (temp.Next == null)
            {
                Console.WriteLine("Position Out of Range");
                return;
            }
            temp.Next = temp.Next.Next;
        }



        //  REVERSE A LINKED LIST

        public ListNode ReverseLinkedList()
        {
            ListNode prev = null;
            ListNode current = Head;

            while(current != null)
            {
                ListNode next = current.Next;
                current.Next = prev;
                prev = current;
                current = next; 
            }
            Head = prev;

            return Head;

        }
        

    }



    class Program
    {

        static void Main(string[] args)
        {
            //ListNode head = new ListNode(10);
            //head.next = new ListNode(20);
            //head.next.next = new ListNode(30);

            //ListNode temp = head;
            //while(temp != null)
            //{
            //    Console.WriteLine(temp.val);
            //    temp = temp.next;
            //}

            LinkedList ll = new LinkedList();

            ll.AtBeginning(10);
            ll.AtBeginning(30); // 30 -> 10
            ll.AtEnd(20);       // 30 -> 10 -> 20
            ll.AtPosition(15, 1); // 30 -> 15 -> 10 -> 20

            Console.WriteLine("Before reverse");
            ll.DisplayList();
            ll.ReverseLinkedList();
            Console.WriteLine("\n After reverse");
            ll.DisplayList();




            ll.DeleteFromBeginning(); // 15 -> 10 -> 20
            ll.DeleteFromEnd();        // 15 -> 10 
            ll.DeleteAtPosition(1);    // 15

            ll.DisplayList();

            Console.WriteLine("\n");

            Console.WriteLine("------------ Custom LinkedList ------------");

            DoublyLinkedList dl = new DoublyLinkedList();
            dl.InsertAtHead(10);
            dl.InsertAtHead(30);
            dl.InsertAtHead(50);
            dl.InsertAtTail(210);

            dl.DisplayList();
            //dl.InsertAtHead(10);
            //dl.InsertAtHead(20);
            //dl.InsertAtHead(30);

        }
    }
}
