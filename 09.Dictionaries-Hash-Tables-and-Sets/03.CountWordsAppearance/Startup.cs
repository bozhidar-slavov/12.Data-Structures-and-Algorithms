namespace CountWordsAppearance
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var reader = new StreamReader("../../words.txt");

            string text = string.Empty;
            using (reader)
            {
                text = reader.ReadToEnd();
                Console.WriteLine(text);
            }

            string[] splitedText = text.Split(new char[] { ',', ' ', '!', '?', '-', '.' }, StringSplitOptions.RemoveEmptyEntries);
            IDictionary<string, int> dictionary = new SortedDictionary<string, int>();

            for (int i = 0; i < splitedText.Length; i++)
            {
                int counter = 1;
                if (dictionary.ContainsKey(splitedText[i].ToLower()))
                {
                    counter = dictionary[splitedText[i].ToLower()] + 1;
                }

                dictionary[splitedText[i].ToLower()] = counter;
            }

            var words = dictionary.OrderBy(x => x.Value);

            foreach (var pair in words)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value} times");
            }
        }
    }
}
