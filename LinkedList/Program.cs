using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Linked List \n");
            LinkedList linkedList = new LinkedList();

            // Adding At First in the LinkedList....
            linkedList.Add(56);
            // Adding At Last in the LinkedList....
            linkedList.Append(70);
            // Inserting Between First and Last Node...
            linkedList.Insert(2, 30);

            // Delete At First in the LinkedList....
            linkedList.Pop();

            // Displaying LinkedList....
            linkedList.Display();
        }
    }
}
