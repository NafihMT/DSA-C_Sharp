using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStack
{
    public class Stack
    {
        public int[] stack;
        public int capacity;
        public int top;
        public Stack(int size)
        {
            capacity = size;
            stack = new int[capacity];
            top = -1;
        }
        public void Push(int data)
        {
            if(top == capacity - 1)
            {
                Console.WriteLine("Stack Overflow");
                return ;
            }
            stack[++top] = data;
        }
        public int Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is Underflow");
                return -1;
            }
            return stack[top--];
        }
        public int Peek()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return stack[top];
        }
        public void Display()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            for(int i = top; i > 0; i--)
            {
                Console.WriteLine(stack[i] + " ");

            }
            Console.WriteLine();

        }

        


    }
}
