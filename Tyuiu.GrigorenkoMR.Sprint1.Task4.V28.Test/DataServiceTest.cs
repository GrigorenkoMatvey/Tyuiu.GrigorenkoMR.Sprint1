using Tyuiu.GrigorenkoMR.Sprint1.Task4.V28.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValiddExpression()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double y = 0.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.0, res);
        }
    }
}
