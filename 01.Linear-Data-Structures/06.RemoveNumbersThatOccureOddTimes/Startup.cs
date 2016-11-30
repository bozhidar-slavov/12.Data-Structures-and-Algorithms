namespace RemoveNumbersThatOccureOddTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var collection = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var filteredNumbersGroups = collection.GroupBy(x => x).Where(x => x.Count() % 2 == 0);

            var filteredNumbers = new List<int>();
            foreach (var group in filteredNumbersGroups)
            {
                filteredNumbers.AddRange(group);
            }

            Console.WriteLine("Without odd occurenced numbers: " + string.Join(", ", filteredNumbers));
        }
    }
}
