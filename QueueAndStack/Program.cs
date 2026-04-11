using System.Collections;
using System.Collections.Generic;

namespace QueueAndStack
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Stack -----------");


            StackLinkedList s1 = new StackLinkedList();
            s1.Push(10);
            s1.Push(20);
            s1.Push(40);
            s1.Push(660);
            
            Console.WriteLine(s1.Pop() +" Peek : "+ s1.Peek());

            s1.Display();

            Console.WriteLine("------------- Queue -----------");

            QueueLinkedList q1 = new QueueLinkedList();
            q1.Enqueue(20);
            q1.Enqueue(22);
            q1.Enqueue(23);
            q1.Enqueue(25);

            Console.WriteLine(q1.Dequeue() + " Peek : "+ q1.Peek());

            q1.Display();



            //Queue<int> q = new Queue<int>();
            //q.Enqueue(10);
            //q.Enqueue(20);
            //q.Enqueue(30);
            //q.Dequeue();
            //Console.WriteLine(q.Peek());
            //Console.WriteLine(q.Contains(10));

            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("------------ Stack --------------");

            //Stack<int> s = new Stack<int>();
            //s.Push(20);
            //s.Push(30);
            //s.Pop();
            //Console.WriteLine("Peek element : "+s.Peek());
            //int c = s.Count();
            //Console.WriteLine(c);
            //Console.WriteLine(s.Contains(20));


            //foreach (int i in s)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("------------ LinkedList --------------");

            //LinkedList<int> li = new LinkedList<int>();
            //li.AddFirst(20);
            //li.AddLast(30);
            //li.AddFirst(10);
            //li.AddLast(5);

            //li.AddBefore(li.Find(5),40);
            //li.AddAfter(li.Find(40), 444);
            //li.Remove(444);
            //li.RemoveFirst();

            //Console.WriteLine("First Element : " + li.First() + "\nLast Element : " + li.Last());

            //foreach(int i in li)
            //{
            //    Console.Write(i + " -> ");
            //}
            //Console.Write("null");



        }
    }
}
