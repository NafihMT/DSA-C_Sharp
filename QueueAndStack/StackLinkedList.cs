using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStack
{
    public class Node
    {
        public int Data;
        public Node next;
        public Node(int data)
        {
            Data = data;
            next = null;
        }
    }
    public class StackLinkedList
    {
        private Node top;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;
        }
        public int Pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }

            int value = top.Data;
            top = top.next;
            return value;
        }

        public int Peek()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return top.Data;
        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
