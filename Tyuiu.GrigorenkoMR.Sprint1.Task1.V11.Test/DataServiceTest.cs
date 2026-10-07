using Tyuiu.GrigorenkoMR.Sprint1.Task1.V11.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.5, res);
        }
    }
}
