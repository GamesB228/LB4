using LB8;

namespace ChartTestin
{
    [TestClass]
    public sealed class ExpSeriesTest
    {
        private ExpSeries exp;
        private double x = 1.0;

        [TestInitialize]
        public void TestInit()
        {
            exp = new ExpSeries();
        }

        [TestMethod]
        public void Loop_Exp_ApproxReturned()
        {
            double y_loop = Math.Round(exp.CalculateLoop(x, 10), 3);
            double y_real = Math.Round(Math.Exp(x), 3);

            Assert.AreEqual(y_real, y_loop);
        }

        [TestMethod]
        public void Recursive_Exp_ApproxReturned()
        {
            double y_rec = Math.Round(exp.CalculateRecursive(x, 10), 3);
            double y_real = Math.Round(Math.Exp(x), 3);

            Assert.AreEqual(y_real, y_rec);
        }
    }
}

