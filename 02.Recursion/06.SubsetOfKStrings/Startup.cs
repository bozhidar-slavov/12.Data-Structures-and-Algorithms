namespace SubsetOfKStrings
{
    using System;

    public class Startup
    {
        private static string[] arr;
        private static string[] set;

        public static void Main()
        {
            int k = 2;
            arr = new string[k];
            set = new string[] { "test", "rock", "fun"};

            GenerateSubsetStrings(0, 0);
        }

        private static void GenerateSubsetStrings(int index, int start)
        {
            if (index == arr.Length)
            {
                Console.WriteLine($"({string.Join(" ", arr)})");
                return;
            }

            for (int i = start; i < set.Length; i++)
            {
                arr[index] = set[i];
                GenerateSubsetStrings(index + 1, i + 1);
            }
        }
    }
}
