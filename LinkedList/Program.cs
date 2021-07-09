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
            linkedList.AddAtFirst(70);
            linkedList.AddAtFirst(30);
            linkedList.AddAtFirst(56);

            // Displaying LinkedList....
            linkedList.Display();
        }
    }
}
