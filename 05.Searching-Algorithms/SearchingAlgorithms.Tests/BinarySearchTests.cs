namespace SearchingAlgorithms.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SortingHomework;

    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearch_ShouldReturnTrue_WhenExistingElementIsPassed()
        {
            var collection = new SortableCollection<int>(new[] { 5, 12, 3, 21, 14, 1 });
            Assert.IsTrue(collection.BinarySearch(3));
        }

        [TestMethod]
        public void BinarySearch_ShouldReturnFalse_WhenNonExistingElementIsPassed()
        {
            var collection = new SortableCollection<int>(new[] { 12, 31, 42, 7, 3, 81 });
            Assert.IsFalse(collection.BinarySearch(100));
        }
    }
}
