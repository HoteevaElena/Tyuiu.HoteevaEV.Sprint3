using Tyuiu.HoteevaEV.Sprint3.Task2.V8.Lib;
namespace Tyuiu.HoteevaEV.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int start = 1;
            int end = 15;
            var res = ds.GetMultiplySeries(start, end);
            var wait = 0.001;
            Assert.AreEqual(wait, res);
        }
    }
}