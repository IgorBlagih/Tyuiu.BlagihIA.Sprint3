using Tyuiu.BlagihIA.Sprint3.Task5.V19.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            int x = 1;
            int i = 1;
            int ip = 1;
            int j = 1;
            int jp = 1;

            double res = ds.GetSumSumSeries(x, i, j, ip, jp);
            double wait  = 1.851;
            Assert.AreEqual(wait, res);

        }
    }
}