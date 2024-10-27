using Tyuiu.BlagihIA.Sprint3.Task2.V9.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task2.V9.Test
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
            int  a = 1;
            double wait = 2;
            double res = ds.GetSumSeries(a, s, e);

            Assert.AreEqual(wait, res);
        }
    }
}