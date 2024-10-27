using Tyuiu.BlagihIA.Sprint3.Task1.V28.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int s = 1;
            int e = 2;
            double a = 1;
            double wait = 0.155;
            double res = ds.GetSumSeries(a, s, e);

            Assert.AreEqual(wait, res);
        }
    }
}