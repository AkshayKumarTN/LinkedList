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
            linkedList.Append(70);
            linkedList.Insert(3, 40);

            if (linkedList.Delete(40))
                Console.WriteLine(" Node with key value 40 is Deleted Successful\n");
            else
                Console.WriteLine(" Node with key value 40 is not Present in the LinkedList\n");
            
            Console.WriteLine(" LinkedList Size : "+linkedList.Size()+"\n");
            // Displaying LinkedList....
            linkedList.Display();
        }
    }
}
