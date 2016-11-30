namespace FindLongestEqualNumberSubsequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var list = new List<int>() { 1, 2, 2, 2, 3, 3, -5, 20, 1, 1, 1, 1 };
            var longestSubsequence = ExtractLongestEqualNumberSubsequence(list);
            Console.WriteLine(string.Join(", ", longestSubsequence));
        }

        private static List<int> ExtractLongestEqualNumberSubsequence(List<int> inputSequence)
        {
            int currentCount = 1;
            int bestCount = 1;
            int bestNumber = int.MinValue;

            for (int i = 0; i < inputSequence.Count - 1; i++)
            {
                if (inputSequence[i] == inputSequence[i + 1])
                {
                    currentCount++;
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestNumber = inputSequence[i];
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            var equalNumbersSubsequence = new List<int>();
            for (int i = 0; i < bestCount; i++)
            {
                equalNumbersSubsequence.Add(bestNumber);
            }

            return equalNumbersSubsequence;
        }
    }
}
