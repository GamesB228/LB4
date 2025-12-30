using LB6;

namespace StudentTest
{
    [TestClass]
    public class StudentCatalogLinqTests
    {
        private StudentCatalog catalog;

        [TestInitialize]
        public void Setup()
        {
            catalog = new StudentCatalog();
            catalog.Add(new Student("A", 2, "CS-21", 10));
            catalog.Add(new Student("B", 2, "CS-21", 12));
            catalog.Add(new Student("C", 3, "CS-22", 8));
            catalog.Add(new Student("D", 3, "CS-22", 12));
            catalog.Add(new Student("E", 1, "CS-20", 9));
        }

        [TestMethod]
        public void TestFilterByGroup()
        {
            var result = catalog.FilterByGroup("CS-21");
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void TestSortByCourse()
        {
            var result = catalog.SortByCourse();
            Assert.AreEqual("E", result[0].FullName);
        }

        [TestMethod]
        public void TestAverageResult()
        {
            var avg = catalog.AverageResult();
            Assert.AreEqual((10 + 12 + 8 + 12 + 9) / 5.0, avg);
        }

        [TestMethod]
        public void TestGroupByCourse()
        {
            var groups = catalog.GroupByCourse();
            Assert.AreEqual(3, groups.Keys.Count); // курси: 1, 2, 3
        }

        [TestMethod]
        public void TestGetNamesWithResultBelow()
        {
            var names = catalog.GetNamesWithResultBelow(10);
            CollectionAssert.AreEquivalent(new List<string> { "C", "E" }, names);
        }
    }
}
