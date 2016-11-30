namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Queue<int> operations = new Queue<int>();

            int startNumber = 5;
            int endNumber = 23;

            while (startNumber <= endNumber)
            {
                operations.Enqueue(endNumber);

                if (endNumber / 2 >= startNumber)
                {
                    if (endNumber % 2 == 0)
                    {
                        endNumber /= 2;
                    }
                    else
                    {
                        endNumber--;
                    }
                }
                else
                {
                    if (endNumber - 2 >= startNumber)
                    {
                        endNumber -= 2;
                    }
                    else
                    {
                        endNumber--;
                    }
                }
            }

            Console.WriteLine(string.Join(" -> ", operations.Reverse()));
        }
    }
}
