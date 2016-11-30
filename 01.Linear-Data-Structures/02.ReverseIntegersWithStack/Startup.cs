namespace ReverseIntegersWithStack
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter length of the stack: ");
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number to fill in the stack: ");
                int currentNumber = int.Parse(Console.ReadLine());
                stack.Push(currentNumber);
            }

            Console.WriteLine("Numbers in reversed order: ");
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
