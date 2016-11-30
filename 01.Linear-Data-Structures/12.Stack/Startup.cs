namespace Stack
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var stack = new Stack<int>();

            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine("Stack items count: {0}", stack.Count);
            Console.WriteLine("Stack capacity: {0}", stack.Capacity);

            stack.Push(6);
            stack.Push(7);

            Console.WriteLine(new string('-', 15));
            Console.WriteLine("After adding 2 more items");
            Console.WriteLine("Stack items count: {0}", stack.Count);
            Console.WriteLine("Stack capacity: {0}", stack.Capacity);
        }
    }
}
