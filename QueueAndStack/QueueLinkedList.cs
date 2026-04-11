using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStack
{
    public class QueueNode
    {
        public int Data;
        public QueueNode next;
        public QueueNode(int data)
        {
            Data = data;
            next = null;
        }
    }
    public class QueueLinkedList
    {
        private QueueNode front;        // For Dequeue
        private QueueNode rear;         // For Enqueue

        public void Enqueue(int data)
        {
            QueueNode newNode = new QueueNode(data);

            if(rear == null)
            {
                front = rear = newNode;
                return;
            }
            rear.next = newNode;           
            rear = newNode;             // Update rear, Otherwise it still point to old rear
        }

        public int Dequeue()
        {
            if(front == null)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            int val = front.Data;
            front = front.next;

            if(front == null)           // if only element
            {
                rear = null;           // rear need to points to null (otherwise it still pointing to removed value
            }

            return val;            

        }

        public void Display()
        {
            QueueNode temp = front;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public int Peek()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            return front.Data;
        }
    }
}
