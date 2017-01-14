namespace SearchingAlgorithms.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SortingHomework;

    [TestClass]
    public class LinearSearchTests
    {
        [TestMethod]
        public void LinearSearch_ShouldReturnTrue_WhenExistingElementIsPassed()
        {
            var collection = new SortableCollection<int>(new[] { 12, -3, 31, 42, 7, 3, 81 });
            Assert.IsTrue(collection.LinearSearch(3));
        }

        [TestMethod]
        public void LinearSearch_ShouldReturnFalse_WhenNonExistingElementIsPassed()
        {
            var collection = new SortableCollection<int>(new[] { 12, -3, 31, 42, 7, 3, 81 });
            Assert.IsFalse(collection.LinearSearch(100));
        }
    }
}
