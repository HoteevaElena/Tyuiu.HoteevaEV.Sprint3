using System.Xml;
using Tyuiu.HoteevaEV.Sprint3.Task3.V6.Lib;
namespace Tyuiu.HoteevaEV.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string s = "12able 1o s4gh";
            char item = 't';
            var res = ds.ReplaceNumOnChar(s, item);
            string wait = "ttable to stgh";
            Assert.AreEqual(wait, res);
        }
    }
}