namespace SortingAlgorithms.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SortingHomework;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class QuickSortTests
    {
        [TestMethod]
        public void QuickSort_ShouldSortIntNumbersCorrectly()
        {
            var collection = new SortableCollection<int>(new[] { -5, 4, 12, -20, 3, 42 });
            collection.Sort(new Quicksorter<int>());

            var expectedCollection = new List<int>(collection.Items);
            expectedCollection.Sort();

            CollectionAssert.Equals(expectedCollection, collection.Items.ToList());
        }

        [TestMethod]
        public void QuickSort_ShouldSortDoubleNumbersCorrectly()
        {
            var collection = new SortableCollection<double>(new[] { 5.5, -10.3, 2.9, -42.2, 13.3 });
            collection.Sort(new Quicksorter<double>());

            var expectedCollection = new List<double>(collection.Items);
            expectedCollection.Sort();

            CollectionAssert.Equals(expectedCollection, collection.Items.ToList());
        }

        [TestMethod]
        public void QuickSort_ShouldSortCharactersCorrectly()
        {
            var collection = new SortableCollection<char>(new[] { 'v', 'b', 'a', 'm', 'p' });
            collection.Sort(new Quicksorter<char>());

            var expectedCollection = new List<char>(collection.Items);
            expectedCollection.Sort();

            CollectionAssert.Equals(expectedCollection, collection.Items.ToList());
        }
    }
}
