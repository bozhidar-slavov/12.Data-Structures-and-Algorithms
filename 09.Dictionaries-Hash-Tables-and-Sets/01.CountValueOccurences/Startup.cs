namespace CountValueOccurences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            double[] array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            IDictionary<double, int> dictionary = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                if (dictionary.ContainsKey(array[i]))
                {
                    counter = dictionary[array[i]] + 1;
                }

                dictionary[array[i]] = counter;
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value} times");
            }
        }
    }
}
