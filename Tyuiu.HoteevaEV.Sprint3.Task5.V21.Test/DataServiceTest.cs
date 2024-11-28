using Tyuiu.HoteevaEV.Sprint3.Task5.V21.Lib;
namespace Tyuiu.HoteevaEV.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int start1 = 1;
            int end1 = 3;
            int start2 = 1;
            int end2 = 10;

            double wait = 25.981;

            double res = ds.GetSumSumSeries(x, start1, start2, end1, end2);

            Assert.AreEqual(wait, res);
        }
    }
}