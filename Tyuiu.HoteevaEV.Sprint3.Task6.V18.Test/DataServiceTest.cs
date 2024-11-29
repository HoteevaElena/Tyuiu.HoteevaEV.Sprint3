using Tyuiu.HoteevaEV.Sprint3.Task6.V18.Lib;
namespace Tyuiu.HoteevaEV.Sprint3.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int value = 10;
            int start = 9;
            int end = 18;

            var wait = 95;
            var res = ds.GetSumTheDivisors(start, end);

            Assert.AreEqual(wait, res);

        }
    }
}