namespace Permutations
{
    using System;

    public class Startup
    {
        private static int[] arr;

        public static void Main()
        {
            int n = 5;
            arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            GeneratePermutations(0);
        }

        private static void GeneratePermutations(int index)
        {
            if (arr.Length == index)
            {
                Console.WriteLine($"({string.Join(" ", arr)})");
                return;
            }

            for (int i = index; i < arr.Length; i++)
            {
                if (i != index)
                {
                    Swap(ref arr[i], ref arr[index]);
                }

                GeneratePermutations(index + 1);

                if (i != index)
                {
                    Swap(ref arr[i], ref arr[index]);
                }
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            var temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
