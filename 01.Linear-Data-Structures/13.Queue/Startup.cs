namespace Queue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var queue = new Queue<int>();

            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine("Queue items count: {0}", queue.Count);
        }
    }
}
