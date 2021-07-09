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
            linkedList.Append(56);
            linkedList.Append(70);
            // Inserting Between First and Last Node...
            linkedList.Insert(2, 30);

            // Displaying LinkedList....
            linkedList.Display();
        }
    }
}
