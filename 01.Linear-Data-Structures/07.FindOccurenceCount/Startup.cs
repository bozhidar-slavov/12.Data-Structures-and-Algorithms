namespace FindOccurenceCount
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var list = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                var currentElement = list[i];
                if (!dictionary.ContainsKey(currentElement))
                {
                    dictionary.Add(currentElement, 1);
                }
                else
                {
                    dictionary[currentElement]++;
                }
            }

            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} --> {number.Value} times");
            }
        }
    }
}
