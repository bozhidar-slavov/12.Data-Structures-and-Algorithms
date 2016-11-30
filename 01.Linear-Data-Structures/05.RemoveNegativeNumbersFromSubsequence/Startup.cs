namespace RemoveNegativeNumbersFromSubsequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var collection = new LinkedList<int>(new int[] { -5, 3, 0, -20, 8, 10, -13 });
            var listWithoutNegatives = RemoveNegativeNumbers(collection);
            Console.WriteLine("Without negative numbers: " + string.Join(", ", listWithoutNegatives));
        }

        private static LinkedList<int> RemoveNegativeNumbers(LinkedList<int> inputSequence)
        {
            var currentNode = inputSequence.First;

            while (currentNode != null)
            {
                if (currentNode.Value < 0)
                {
                    var numberToRemove = currentNode;
                    currentNode = currentNode.Next;
                    inputSequence.Remove(numberToRemove);
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }

            return inputSequence;
        }
    }
}
