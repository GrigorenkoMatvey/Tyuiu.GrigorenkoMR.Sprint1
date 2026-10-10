using Tyuiu.GrigorenkoMR.Sprint1.Task6.V12.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string text = "рыбка собака корова рыбка";
            var res = ds.CheckLastWordRepetiton(text);
            Assert.IsTrue(res);
        }
    }
}
