using Tyuiu.BlagihIA.Sprint3.Task4.V2.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int st = -1;
            int sp = 2;

            double res = ds.Calculate(st, sp);
            double wait = -0.54;
            Assert.AreEqual(wait, res);
      
        }
    }
}