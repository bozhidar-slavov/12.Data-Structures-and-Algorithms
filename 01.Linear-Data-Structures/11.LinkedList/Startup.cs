namespace LinkedList
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            LinkedList<int> testLinkedList = new LinkedList<int>();

            testLinkedList.AddFirst(5);
            testLinkedList.AddFirst(4);
            testLinkedList.AddLast(6);
            testLinkedList.AddLast(7);
            testLinkedList.RemoveFirst();
            testLinkedList.RemoveLast();

            foreach (var item in testLinkedList)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine("Linked list items count: {0}", testLinkedList.Count());
        }
    }
}
