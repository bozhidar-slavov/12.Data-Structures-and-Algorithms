namespace SortSequenceOfIntegersIncreasing
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter an integer number: ");
            string input = Console.ReadLine();

            var list = new List<int>();
            int currentNumber;
            while (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out currentNumber))
                {
                    list.Add(currentNumber);
                }
                else
                {
                    Console.WriteLine("Invalid integer!");
                }

                Console.Write("Enter an integer number: ");
                input = Console.ReadLine();
            }

            list.Sort();
            Console.WriteLine("Sorted: " + string.Join(", ", list));
        }
    }
}
