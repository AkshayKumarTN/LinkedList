using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Linked List \n");
            LinkedList linkedList = new LinkedList();

            // Adding At Last in the LinkedList....
            linkedList.AddAtLast(56);
            linkedList.AddAtLast(30);
            linkedList.AddAtLast(70);

            // Displaying LinkedList....
            linkedList.Display();
        }
    }
}
