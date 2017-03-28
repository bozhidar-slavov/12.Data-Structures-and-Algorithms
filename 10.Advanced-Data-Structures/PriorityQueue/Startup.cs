namespace PriorityQueue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            queue.Enqueue("Kiro");
            queue.Enqueue("Unufri");
            queue.Enqueue("Mimi");
            queue.Enqueue("Penka");
            queue.Enqueue("Gosho");
            queue.Enqueue("Zoro");

            Console.WriteLine($"The root: {queue.Root}");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
