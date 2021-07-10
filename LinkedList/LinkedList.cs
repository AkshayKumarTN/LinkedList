using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedLists
    {
        internal Node head;
        public LinkedLists()
        {
            this.head = null;
        }

        public void Add(int data)
        {
            // Adding At First in the LinkedList....

            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                node.Next = head;
                head = node;
            }       
        }
        public void Append(int data)
        {
            // Adding At Last in the LinkedList....
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
        public void Insert(int position, int data)
        {
            // Inserting Between First and Last Node...
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
        public void Pop()
        {
            // Delete At First in the LinkedList....
            if (head == null)
                Console.WriteLine(" List is Empty ");
            else
                head = head.Next;

        }
        public void PopLast()
        {
            // Delete At Last in the LinkedList....
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

        public bool Search(int data)
        {
            // Searching a Data in the LinkedList....

            if (head == null)
                return false;
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == data)
                        return true;
                    temp = temp.Next;
                }
                return false;
            }
        }
        

        public void Display()
        {
            // Displaying LinkedList....
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
