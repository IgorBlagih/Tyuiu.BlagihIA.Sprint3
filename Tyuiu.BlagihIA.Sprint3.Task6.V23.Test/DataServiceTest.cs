using Tyuiu.BlagihIA.Sprint3.Task6.V23.Lib;
namespace Tyuiu.BlagihIA.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int st = 9;
            int sp = 10;

            int res = ds.GetSumTheDivisors(st, sp);
            int wait = 7;

            Assert.AreEqual(wait, res);
        }
    }
}