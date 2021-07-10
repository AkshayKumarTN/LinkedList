using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SortedLinkedList
    {
        internal Node head;
        public SortedLinkedList()
        {
            this.head = null;
        }

        public void Add(int data)
        {
            // Sorted while Adding in the LinkedList....

            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                if(temp.data>data)
                {
                    node.Next = head;
                    head = node;
                }
                else
                {
                    while (temp.Next!=null && temp.Next.data < data)
                        temp = temp.Next;
                    node.Next = temp.Next;
                    temp.Next = node;
                }
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

        public bool Delete(int data)
        {
            bool alive = false;
            if (head == null)
            {
                Console.WriteLine("Empty LinkedList");
                return alive;
            }
            else
            {
                if (head.data == data)
                {
                    head = null;
                    return alive;
                }
                else
                {
                    Node temp = head;
                    while (temp.Next != null)
                    {
                        if (temp.Next.data == data)
                        {
                            temp.Next = temp.Next.Next;
                            alive = true;
                            break;
                        }
                        temp = temp.Next;
                    }
                    return alive;
                }
            }
        }

        public int Size()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.Next;
            }
            return size;
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
