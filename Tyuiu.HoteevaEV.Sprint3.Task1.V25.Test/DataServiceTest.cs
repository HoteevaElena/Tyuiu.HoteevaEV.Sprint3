using Tyuiu.HoteevaEV.Sprint3.Task1.V25.Lib;

namespace Tyuiu.HoteevaEV.Sprint3.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int a = 2;
            int startk = 1;
            int stopk = 6;
            double wait = 844.664;
            double res = ds.GetMultiplySeries(a, startk, stopk);
            Assert.AreEqual(wait, res);

        }
    }
}