using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Linked List ");
            Node head = new Node(56);
            head.Next = new Node(30);
            head.Next.Next = new Node(30);
        }
    }
}
