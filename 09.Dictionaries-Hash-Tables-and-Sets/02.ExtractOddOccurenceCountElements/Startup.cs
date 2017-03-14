namespace ExtractOddOccurenceCountElements
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            string[] elements = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            IDictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < elements.Length; i++)
            {
                int counter = 1;
                if (dictionary.ContainsKey(elements[i]))
                {
                    counter = dictionary[elements[i]] + 1;
                }

                dictionary[elements[i]] = counter;
            }

            foreach(var pair in dictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value} times");
                }
            }
        }
    }
}
