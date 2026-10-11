using Tyuiu.GrigorenkoMR.Sprint1.Task7.V20.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.449, res);
        }
    }
}
