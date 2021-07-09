using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        public LinkedList()
        {
            this.head = null;
        }
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                node.Next = head;
                head = node;
            }       
        }
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = node;
            }
        }
        internal void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.Next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.Next;
                    position--;
                }
                node.Next = temp.Next;
                temp.Next = node;
            }
        }
        internal void Pop()
        {
            if (head == null)
                Console.WriteLine(" List is Empty ");
            else
                head = head.Next;

        }
        internal void PopLast()
        {
            if (head == null)
               Console.WriteLine("Empty LinkedList");
            else
            {
                if (head.Next == null)
                    head = null;
                else
                {
                    Node temp = head;
                    while (temp.Next.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = null;
                }
            }
        }
        internal void Display()
        {
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Console.Write("  ");
                while (temp != null)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.Next;
                }
                Console.Write("Null\n");
            }
        }
    }
}
