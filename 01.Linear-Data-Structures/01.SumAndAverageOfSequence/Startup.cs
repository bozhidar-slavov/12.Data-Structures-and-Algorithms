namespace SumAndAverageOfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();

            var list = new List<int>();
            int currentNumber;
            while (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out currentNumber) && currentNumber > 0)
                {
                    list.Add(currentNumber);
                }
                else
                {
                    Console.WriteLine("Invalid integer!");
                }

                Console.Write("Enter a positive integer: ");
                input = Console.ReadLine();
            }

            var sum = list.Sum();
            var average = list.Average();

            Console.WriteLine($"Sum -> {sum}");
            Console.WriteLine($"Average -> {average:F2}");
        }
    }
}
