namespace PrintSequenceWithQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private const int StartNumber = 2;
        private const int Loops = 50;

        public static void Main()
        {
            var queue = new Queue<int>();

            queue.Enqueue(StartNumber);
            for (int i = 0; i < Loops; i++)
            {
                queue.Enqueue(queue.First() + 1);
                queue.Enqueue(queue.First() * 2 + 1);
                queue.Enqueue(queue.First() + 2);
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
