namespace VariationsNK
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
            set = new string[] { "hi", "a", "b" };

            GenerateVariations(0);
        }

        private static void GenerateVariations(int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine($"({string.Join(" ", arr)})");
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                arr[index] = set[i];
                GenerateVariations(index + 1);
            }
        }
    }
}
