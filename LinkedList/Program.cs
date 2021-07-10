using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Linked List \n");
            LinkedLists linkedList = new LinkedLists();

            // Adding At First in the LinkedList....
            linkedList.Add(56);
            // Adding At Last in the LinkedList....
            linkedList.Append(70);
            // Inserting Between First and Last Node...
            linkedList.Insert(2, 30);

            // Delete At Last in the LinkedList....
            linkedList.PopLast();
            // Searching a Data in the LinkedList....
            if (linkedList.Search(30))
                Console.WriteLine(" Node with value 30 is Found\n");
            else
                Console.WriteLine(" Node with value 30 is Not Found\n");

            // Displaying LinkedList....
            linkedList.Display();
        }
    }
}
