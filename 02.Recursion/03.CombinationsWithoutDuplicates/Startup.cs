namespace CombinationsWithDuplicates
{
    using System;

    public class Startup
    {
        private static int[] arr;
        private static int[] set;

        public static void Main()
        {
            int n = 4;
            int k = 2;

            arr = new int[k];
            set = new int[n];

            for (int i = 0; i < set.Length; i++)
            {
                set[i] = i + 1;
            }

            GenerateCombinations(0, 0);
        }

        private static void GenerateCombinations(int index, int start)
        {
            if (index == arr.Length)
            {
                Console.WriteLine($"({string.Join(" ", arr)})");
                return;
            }

            for (int i = start; i < set.Length; i++)
            {
                arr[index] = set[i];
                GenerateCombinations(index + 1, i + 1); // difference from previuos algorithm
            }
        }
    }
}
