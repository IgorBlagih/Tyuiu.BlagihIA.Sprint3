using Tyuiu.BlagihIA.Sprint3.Task0.V28.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            int i = 1;
            int end = 2; 
            double wait = 12;
            double res = ds.GetMultiplySeries(x, i, end);

            Assert.AreEqual(wait, res);

        }
    }
}