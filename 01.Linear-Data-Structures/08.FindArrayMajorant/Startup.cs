namespace FindArrayMajorant
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // Change the numbers in the sequence to test other cases
            var arrayOfNumbers = new[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var groupedByOccurence = arrayOfNumbers.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault();

            if (groupedByOccurence != null && groupedByOccurence.Count() > arrayOfNumbers.Count() / 2)
            {
                Console.WriteLine($"Majorant --> {groupedByOccurence.Key} ({groupedByOccurence.Count()} occurences)");
            }
            else
            {
                Console.WriteLine("No majorant in this sequence!");
            }
        }
    }
}
