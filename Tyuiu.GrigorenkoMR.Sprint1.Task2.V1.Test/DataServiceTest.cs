using Tyuiu.GrigorenkoMR.Sprint1.Task2.V1.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            int km = 82;
            var res = ds.ConvertKmToM(km);
            Assert.AreEqual(50.963, res);
        }
    }
}
