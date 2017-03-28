namespace SetOfWords
{
    using System;
    using System.IO;
    using System.Linq;
    using Triepocalypse;

    public class Startup
    {
        public static void Main()
        {
            Trie<int> trie = new Trie<int>();

            using (StreamReader reader = new StreamReader("..\\..\\input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    reader
                        .ReadLine()
                        .Split(' ', '.', ',', '?', '!', ':')
                        .ToList()
                        .ForEach(word =>
                        {
                            if (!trie.ContainsKey(word))
                            {
                                trie.Add(word, 1);
                            }
                            else
                            {
                                trie[word] += 1;
                            }
                        });
                }
            }

            trie.Matcher.Next("lorem");

            int countOfLorem = 0;

            if (trie.Matcher.IsMatch())
            {
                countOfLorem = trie.Matcher.GetExactMatch();
            }

            Console.WriteLine(countOfLorem);
        }
    }
}
