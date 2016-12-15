namespace NestedLoops
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int size = 3; // change size to check different results
            int[] array = new int[size];

            GenerateVariations(0, array);
        }

        static void GenerateVariations(int index, int[] array)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(", ", array));
                return;
            }

            for (int i = 1; i <= array.Length; i++)
            {
                array[index] = i;
                GenerateVariations(index + 1, array);
            }
        }
    }
}
