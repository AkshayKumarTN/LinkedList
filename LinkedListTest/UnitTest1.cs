using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSearchMethod()
        {
            LinkedLists linkedList = new LinkedLists();
            // Adding At First in the LinkedList....
            linkedList.Add(56);
            // Adding At Last in the LinkedList....
            linkedList.Append(70);
            // Inserting Between First and Last Node...
            linkedList.Insert(2, 30);
            Assert.IsTrue(linkedList.Search(30));
        }
        [TestMethod]
        public void TestInsertMethod()
        {
            LinkedLists linkedList = new LinkedLists();
            // Adding At First in the LinkedList....
            linkedList.Add(56);
            // Adding At Last in the LinkedList....
            linkedList.Append(70);
            // Inserting Between First and Last Node...
            linkedList.Insert(2, 30);
            linkedList.Insert(3, 40);
            Assert.IsTrue(linkedList.Search(40));
        }
    }
}
