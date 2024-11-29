using Tyuiu.HoteevaEV.Sprint3.Task7.V6.Lib;
namespace Tyuiu.HoteevaEV.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int s = -5;
            int end = 5;

            //int len = s - end + 1;
            //double[] vals = new double[len];

            double[] tryvals = new double[11];
            tryvals[0] = 23.92;
            tryvals[1] = 18.88;
            tryvals[2] = 13.10;
            tryvals[3] = 7.24;
            tryvals[4] = 1.80;
            tryvals[5] = -8;
            tryvals[6] = -5.70;
            tryvals[7] = -11.26;
            tryvals[8] = -17.12;
            tryvals[9] = -22.88;
            tryvals[10] = -27.92;

            double[] res = new double[11];
            res = ds.GetMassFunction(s, end);

            CollectionAssert.AreEqual(tryvals, res);
        }
    }
}